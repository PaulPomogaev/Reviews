namespace ReviewsWebApplication.Configuration
{
    public class JwtSettings
    {
        public string ValidIssuer { get; set; } = default!;
        public string ValidAudience { get; set; } = default!;
        public string Secret { get; set; } = default!;
    }
}
