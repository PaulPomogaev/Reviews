using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Review.Domain;
using Review.Domain.Helper;
using Review.Domain.Services;
using ReviewsWebApplication.Configuration;
using System.Reflection;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddControllers(); 
        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "Review API",
                Description = "API for managing product reviews and ratings",
                Contact = new OpenApiContact
                {
                    Name = "Paul_Pomogaev",
                    Email = "paulslock1@gmail.com"
                }
            });

            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "Enter your token",
            });

            options.AddSecurityRequirement(new OpenApiSecurityRequirement 
            {
               {
                  new OpenApiSecurityScheme 
                  {
                     Reference = new OpenApiReference 
                     {
                        Id = "Bearer",
                        Type = ReferenceType.SecurityScheme
                     }
                  },
                  new List < string > ()
               }
            });

            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            if (File.Exists(xmlPath))
            {
                options.IncludeXmlComments(xmlPath);
            }
        });


        var connectionString = builder.Configuration.GetConnectionString("Review_Database");
        builder.Services.AddDbContext<DataBaseContext>(options => options.UseSqlServer(connectionString));

        builder.Services.AddScoped<IFeedbackService, FeedbackService>();
        builder.Services.AddScoped<LoginService>();
        builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JWT"));


        builder.Services.AddAuthentication(options => 
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options => 
        {
            var issuer = builder.Configuration["JWT:ValidIssuer"];
            var audience = builder.Configuration["JWT:ValidAudience"];
            var secret = builder.Configuration["JWT:Secret"];
            if (string.IsNullOrEmpty(secret))
            {
                throw new InvalidOperationException("JWT Secret не прошёл конфигурацию в appsettings.json");
            }

            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = issuer,
                ValidAudience = audience,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret))
            };
        });

        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(policy =>
            {
                policy.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader();
            });
        });

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Review API v1");
            });
        }

        app.UseHttpsRedirection();
        app.UseCors();
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();

        using (var scope = app.Services.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<DataBaseContext>();
            var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

            if (app.Environment.IsDevelopment())
            {
                try
                {
                    context.Database.Migrate();
                    if (app.Environment.IsDevelopment())
                    {
                        
                        logger.LogInformation("Очистка и повторная генерация тестовых данных...");

                        context.Database.ExecuteSqlRaw("DELETE FROM Reviews");
                        context.Database.ExecuteSqlRaw("DELETE FROM Logins");

                        var reviews = Initialization.SetReviews();
                        var logins = Initialization.SetLogins();

                        context.Reviews.AddRange(reviews);
                        context.Logins.AddRange(logins);
                        context.SaveChanges();

                        logger.LogInformation($"Сгенерировано {reviews.Length} отзывов и {logins.Length} логинов.");
                    }
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Ошибка инициализации базы данных");
                    throw;
                }
            }
        }

        app.Run();
    }
}