using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Review.Domain.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Grade = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RatingId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Ratings_RatingId",
                        column: x => x.RatingId,
                        principalTable: "Ratings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[] { 1, "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CreateDate", "Grade", "ProductId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 17, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1300), 2.1400000000000001, 8 },
                    { 2, new DateTime(2025, 9, 1, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1360), 1.71, 2 },
                    { 3, new DateTime(2025, 10, 14, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1413), 3.0, 2 },
                    { 4, new DateTime(2025, 10, 3, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1632), 2.6699999999999999, 9 },
                    { 5, new DateTime(2025, 9, 13, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1658), 2.5, 1 },
                    { 6, new DateTime(2025, 9, 26, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1709), 2.6699999999999999, 8 },
                    { 7, new DateTime(2025, 8, 30, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1737), 2.75, 8 },
                    { 8, new DateTime(2025, 11, 4, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1749), 1.0, 3 },
                    { 9, new DateTime(2025, 9, 16, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1776), 2.75, 7 },
                    { 10, new DateTime(2025, 9, 4, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1809), 3.7999999999999998, 5 },
                    { 11, new DateTime(2025, 11, 12, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1908), 1.5, 3 },
                    { 12, new DateTime(2025, 8, 25, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1964), 2.8900000000000001, 2 },
                    { 13, new DateTime(2025, 11, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2008), 2.5699999999999998, 7 },
                    { 14, new DateTime(2025, 11, 13, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2035), 0.67000000000000004, 4 },
                    { 15, new DateTime(2025, 11, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2059), 0.67000000000000004, 2 },
                    { 16, new DateTime(2025, 9, 9, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2200), 2.6699999999999999, 7 },
                    { 17, new DateTime(2025, 9, 25, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2240), 2.5, 4 },
                    { 18, new DateTime(2025, 10, 26, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2263), 4.3300000000000001, 8 },
                    { 19, new DateTime(2025, 11, 20, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2300), 2.8300000000000001, 7 },
                    { 20, new DateTime(2025, 10, 17, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2353), 1.8799999999999999, 6 },
                    { 21, new DateTime(2025, 10, 7, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2366), 0.0, 4 },
                    { 22, new DateTime(2025, 10, 18, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2447), 3.0, 4 },
                    { 23, new DateTime(2025, 11, 30, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2480), 2.25, 6 },
                    { 24, new DateTime(2025, 11, 23, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2522), 2.1699999999999999, 9 },
                    { 25, new DateTime(2025, 10, 26, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2565), 2.5699999999999998, 2 },
                    { 26, new DateTime(2025, 11, 22, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2591), 3.0, 2 },
                    { 27, new DateTime(2025, 9, 28, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2608), 1.5, 9 },
                    { 28, new DateTime(2025, 9, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2718), 3.5, 9 },
                    { 29, new DateTime(2025, 11, 8, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2738), 3.0, 8 },
                    { 30, new DateTime(2025, 9, 14, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2777), 2.0, 2 },
                    { 31, new DateTime(2025, 10, 15, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2814), 3.1699999999999999, 2 },
                    { 32, new DateTime(2025, 10, 20, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2851), 2.7999999999999998, 4 },
                    { 33, new DateTime(2025, 11, 14, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(2958), 1.5700000000000001, 9 },
                    { 34, new DateTime(2025, 9, 4, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3014), 2.3300000000000001, 7 },
                    { 35, new DateTime(2025, 9, 28, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3031), 3.0, 8 },
                    { 36, new DateTime(2025, 9, 24, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3087), 1.8899999999999999, 5 },
                    { 37, new DateTime(2025, 9, 15, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3126), 1.4299999999999999, 4 },
                    { 38, new DateTime(2025, 9, 26, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3228), 2.0, 8 },
                    { 39, new DateTime(2025, 9, 28, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3275), 2.3799999999999999, 5 },
                    { 40, new DateTime(2025, 9, 25, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3316), 3.1699999999999999, 1 },
                    { 41, new DateTime(2025, 9, 11, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3342), 3.5, 2 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CreateDate", "Grade", "ProductId" },
                values: new object[,]
                {
                    { 42, new DateTime(2025, 9, 9, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3455), 2.5, 8 },
                    { 43, new DateTime(2025, 10, 24, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3469), 2.0, 8 },
                    { 44, new DateTime(2025, 10, 24, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3497), 3.0, 5 },
                    { 45, new DateTime(2025, 10, 11, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3525), 2.5, 4 },
                    { 46, new DateTime(2025, 9, 17, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3562), 3.0, 7 },
                    { 47, new DateTime(2025, 10, 18, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3600), 2.0, 9 },
                    { 48, new DateTime(2025, 10, 20, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3753), 2.8300000000000001, 9 },
                    { 49, new DateTime(2025, 11, 28, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3806), 3.3300000000000001, 9 },
                    { 50, new DateTime(2025, 11, 13, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3850), 2.0, 4 },
                    { 51, new DateTime(2025, 10, 7, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3887), 0.67000000000000004, 4 },
                    { 52, new DateTime(2025, 9, 2, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3899), 2.0, 3 },
                    { 53, new DateTime(2025, 11, 8, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3993), 3.0, 9 },
                    { 54, new DateTime(2025, 10, 6, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4021), 2.6699999999999999, 8 },
                    { 55, new DateTime(2025, 11, 10, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4052), 0.59999999999999998, 1 },
                    { 56, new DateTime(2025, 11, 22, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4096), 1.4299999999999999, 1 },
                    { 57, new DateTime(2025, 10, 4, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4137), 2.4300000000000002, 1 },
                    { 58, new DateTime(2025, 9, 16, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4238), 1.8600000000000001, 4 },
                    { 59, new DateTime(2025, 10, 9, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4286), 2.8599999999999999, 6 },
                    { 60, new DateTime(2025, 10, 8, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4312), 3.25, 3 },
                    { 61, new DateTime(2025, 11, 9, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4351), 3.1699999999999999, 2 },
                    { 62, new DateTime(2025, 10, 20, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4391), 3.5699999999999998, 3 },
                    { 63, new DateTime(2025, 11, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4479), 3.0, 2 },
                    { 64, new DateTime(2025, 11, 7, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4498), 2.5, 1 },
                    { 65, new DateTime(2025, 11, 13, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4523), 1.5, 3 },
                    { 66, new DateTime(2025, 8, 27, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4536), 5.0, 5 },
                    { 67, new DateTime(2025, 11, 8, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4567), 2.75, 5 },
                    { 68, new DateTime(2025, 10, 11, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4579), 3.0, 1 },
                    { 69, new DateTime(2025, 10, 25, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4629), 3.0, 4 },
                    { 70, new DateTime(2025, 10, 9, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4719), 2.0, 8 },
                    { 71, new DateTime(2025, 9, 15, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4738), 1.5, 1 },
                    { 72, new DateTime(2025, 10, 2, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4769), 4.2000000000000002, 9 },
                    { 73, new DateTime(2025, 8, 29, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4798), 4.0, 5 },
                    { 74, new DateTime(2025, 9, 28, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4840), 2.8599999999999999, 1 },
                    { 75, new DateTime(2025, 8, 31, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4889), 2.5, 9 },
                    { 76, new DateTime(2025, 9, 29, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(4990), 3.8799999999999999, 1 },
                    { 77, new DateTime(2025, 11, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5004), 4.0, 1 },
                    { 78, new DateTime(2025, 11, 10, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5048), 2.5699999999999998, 2 },
                    { 79, new DateTime(2025, 10, 12, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5066), 2.0, 3 },
                    { 80, new DateTime(2025, 11, 28, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5103), 3.8300000000000001, 1 },
                    { 81, new DateTime(2025, 9, 1, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5183), 2.6000000000000001, 2 },
                    { 82, new DateTime(2025, 8, 26, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5210), 2.0, 9 },
                    { 83, new DateTime(2025, 10, 30, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5222), 4.0, 7 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CreateDate", "Grade", "ProductId" },
                values: new object[,]
                {
                    { 84, new DateTime(2025, 10, 20, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5239), 2.0, 8 },
                    { 85, new DateTime(2025, 8, 24, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5253), 2.0, 5 },
                    { 86, new DateTime(2025, 9, 4, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5314), 1.8899999999999999, 4 },
                    { 87, new DateTime(2025, 9, 7, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5359), 2.0, 4 },
                    { 88, new DateTime(2025, 9, 6, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5456), 2.3799999999999999, 3 },
                    { 89, new DateTime(2025, 11, 27, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5475), 2.5, 8 },
                    { 90, new DateTime(2025, 11, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5502), 1.5, 1 },
                    { 91, new DateTime(2025, 9, 20, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5542), 2.5699999999999998, 9 },
                    { 92, new DateTime(2025, 8, 28, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5577), 2.3999999999999999, 1 },
                    { 93, new DateTime(2025, 11, 1, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5717), 2.8799999999999999, 4 },
                    { 94, new DateTime(2025, 9, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5773), 2.8900000000000001, 2 },
                    { 95, new DateTime(2025, 10, 29, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5817), 3.0, 6 },
                    { 96, new DateTime(2025, 9, 15, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5866), 2.2200000000000002, 5 },
                    { 97, new DateTime(2025, 9, 12, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5879), 1.0, 1 },
                    { 98, new DateTime(2025, 10, 23, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5950), 2.5, 6 },
                    { 99, new DateTime(2025, 9, 24, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5999), 2.6200000000000001, 9 },
                    { 100, new DateTime(2025, 10, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(6049), 1.1100000000000001, 1 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreateDate", "DeleteReason", "DeletedAt", "DeletedBy", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 27, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(342), null, null, null, 3, 5, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusm", 9 },
                    { 2, new DateTime(2025, 9, 5, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(393), null, null, null, 5, 9, 3, 2, "Lorem ipsum dolor sit amet, con", 3 },
                    { 3, new DateTime(2025, 11, 21, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(401), null, null, null, 3, 9, 8, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut la", 3 },
                    { 4, new DateTime(2025, 11, 11, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(405), null, null, null, 1, 5, 3, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp", 6 },
                    { 5, new DateTime(2025, 9, 14, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(412), null, null, null, 2, 2, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing ", 4 },
                    { 6, new DateTime(2025, 11, 8, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(416), null, null, null, 1, 4, 6, 2, "Lorem ipsum dolor sit amet, consectetur adipisicin", 2 },
                    { 7, new DateTime(2025, 11, 28, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(420), null, null, null, 3, 7, 8, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididun", 5 },
                    { 8, new DateTime(2025, 8, 30, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(565), null, null, null, 4, 9, 3, 1, "Lorem ipsum dolor sit amet, consec", 7 },
                    { 9, new DateTime(2025, 9, 10, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(572), null, null, null, 2, 6, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicin", 2 },
                    { 10, new DateTime(2025, 11, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(576), null, null, null, 0, 9, 3, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt", 1 },
                    { 11, new DateTime(2025, 10, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(580), null, null, null, 2, 8, 8, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labor", 5 },
                    { 12, new DateTime(2025, 11, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(585), null, null, null, 3, 4, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", 8 },
                    { 13, new DateTime(2025, 10, 11, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(590), null, null, null, 0, 9, 2, 2, "Lorem ipsum dolor sit amet, consectetur adipisi", 9 },
                    { 14, new DateTime(2025, 10, 4, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(594), null, null, null, 5, 5, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusm", 1 },
                    { 15, new DateTime(2025, 9, 24, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(599), null, null, null, 4, 5, 1, 0, "Lorem ipsum dolor sit ", 3 },
                    { 16, new DateTime(2025, 10, 17, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(604), null, null, null, 2, 4, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed d", 1 },
                    { 17, new DateTime(2025, 11, 9, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(608), null, null, null, 0, 2, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed d", 5 },
                    { 18, new DateTime(2025, 9, 30, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(614), null, null, null, 1, 9, 7, 2, "Lorem ipsum dolor sit amet, consectetur ad", 7 },
                    { 19, new DateTime(2025, 11, 3, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(619), null, null, null, 2, 5, 8, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut l", 1 },
                    { 20, new DateTime(2025, 11, 24, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(624), null, null, null, 0, 4, 5, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut", 5 },
                    { 21, new DateTime(2025, 10, 11, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(628), null, null, null, 0, 6, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmo", 3 },
                    { 22, new DateTime(2025, 9, 10, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(633), null, null, null, 2, 3, 7, 1, "Lorem ipsum dolor sit amet", 6 },
                    { 23, new DateTime(2025, 10, 4, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(637), null, null, null, 2, 6, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed", 1 },
                    { 24, new DateTime(2025, 10, 3, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(641), null, null, null, 3, 3, 5, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ", 4 },
                    { 25, new DateTime(2025, 11, 8, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(645), null, null, null, 4, 5, 7, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp", 2 },
                    { 26, new DateTime(2025, 9, 7, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(650), null, null, null, 5, 7, 1, 2, "Lorem ipsum dolor sit amet, consectetur adip", 6 },
                    { 27, new DateTime(2025, 9, 5, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(655), null, null, null, 3, 8, 3, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eius", 1 },
                    { 28, new DateTime(2025, 10, 29, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(660), null, null, null, 2, 6, 3, 1, "Lorem ipsum dolor sit amet, co", 7 },
                    { 29, new DateTime(2025, 11, 9, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(664), null, null, null, 5, 2, 7, 1, "Lorem ipsum dolor si", 5 },
                    { 30, new DateTime(2025, 11, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(669), null, null, null, 2, 4, 5, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed d", 5 },
                    { 31, new DateTime(2025, 10, 31, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(673), null, null, null, 0, 3, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing ", 2 },
                    { 32, new DateTime(2025, 9, 29, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(680), null, null, null, 4, 3, 2, 0, "Lorem ipsum dolor sit amet, cons", 6 },
                    { 33, new DateTime(2025, 9, 10, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(685), null, null, null, 5, 5, 9, 2, "Lorem ipsum dolor sit", 9 },
                    { 34, new DateTime(2025, 10, 9, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(690), null, null, null, 1, 4, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipi", 7 },
                    { 35, new DateTime(2025, 10, 2, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(695), null, null, null, 2, 3, 4, 2, "Lorem ipsum dolor sit", 1 },
                    { 36, new DateTime(2025, 9, 13, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(699), null, null, null, 3, 9, 8, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed", 2 },
                    { 37, new DateTime(2025, 9, 12, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(703), null, null, null, 2, 4, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut la", 4 },
                    { 38, new DateTime(2025, 10, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(707), null, null, null, 4, 2, 9, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", 8 },
                    { 39, new DateTime(2025, 9, 22, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(715), null, null, null, 3, 7, 5, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt", 5 },
                    { 40, new DateTime(2025, 10, 10, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(721), null, null, null, 2, 6, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisi", 6 },
                    { 41, new DateTime(2025, 9, 29, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(724), null, null, null, 3, 2, 9, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inci", 6 },
                    { 42, new DateTime(2025, 11, 1, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(784), null, null, null, 2, 6, 2, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt", 4 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreateDate", "DeleteReason", "DeletedAt", "DeletedBy", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[,]
                {
                    { 43, new DateTime(2025, 9, 12, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(791), null, null, null, 1, 9, 3, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed ", 6 },
                    { 44, new DateTime(2025, 10, 23, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(794), null, null, null, 0, 2, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusm", 1 },
                    { 45, new DateTime(2025, 8, 29, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(799), null, null, null, 4, 5, 4, 0, "Lorem ipsum dolor sit amet, consectetur ad", 3 },
                    { 46, new DateTime(2025, 8, 28, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(803), null, null, null, 5, 2, 6, 1, "Lorem ipsum dolor sit amet, consectetur adipisicin", 9 },
                    { 47, new DateTime(2025, 10, 7, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(808), null, null, null, 1, 2, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt", 1 },
                    { 48, new DateTime(2025, 10, 29, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(813), null, null, null, 3, 5, 7, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod ", 9 },
                    { 49, new DateTime(2025, 10, 27, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(818), null, null, null, 4, 6, 1, 2, "Lorem ipsum dolor sit", 5 },
                    { 50, new DateTime(2025, 9, 15, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(822), null, null, null, 0, 6, 3, 2, "Lorem ipsum dolor sit amet, co", 6 },
                    { 51, new DateTime(2025, 10, 18, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(828), null, null, null, 4, 2, 3, 0, "Lorem ipsum dolor sit amet, consectet", 9 },
                    { 52, new DateTime(2025, 10, 24, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(832), null, null, null, 4, 1, 1, 1, "Lorem ipsum dolor sit amet,", 5 },
                    { 53, new DateTime(2025, 11, 18, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(838), null, null, null, 5, 3, 3, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed", 5 },
                    { 54, new DateTime(2025, 8, 25, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(842), null, null, null, 3, 2, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod te", 2 },
                    { 55, new DateTime(2025, 11, 4, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(846), null, null, null, 0, 2, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut", 2 },
                    { 56, new DateTime(2025, 11, 14, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(851), null, null, null, 3, 4, 5, 1, "Lorem ipsum dolor sit amet, consectetur ad", 4 },
                    { 57, new DateTime(2025, 9, 8, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(855), null, null, null, 4, 6, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inci", 3 },
                    { 58, new DateTime(2025, 9, 20, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(859), null, null, null, 5, 9, 2, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", 9 },
                    { 59, new DateTime(2025, 10, 15, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(863), null, null, null, 1, 3, 6, 0, "Lorem ipsum dolor sit amet, consectetur a", 7 },
                    { 60, new DateTime(2025, 9, 9, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(868), null, null, null, 3, 6, 3, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt u", 7 },
                    { 61, new DateTime(2025, 11, 22, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(872), null, null, null, 5, 7, 9, 0, "Lorem ipsum dolor si", 4 },
                    { 62, new DateTime(2025, 11, 4, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(877), null, null, null, 5, 1, 3, 2, "Lorem ipsum dolor sit amet, consectetur adipisici", 3 },
                    { 63, new DateTime(2025, 10, 7, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(883), null, null, null, 0, 3, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labor", 5 },
                    { 64, new DateTime(2025, 9, 27, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(888), null, null, null, 2, 7, 7, 0, "Lorem ipsum dolor sit amet", 9 },
                    { 65, new DateTime(2025, 11, 14, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(891), null, null, null, 3, 6, 7, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i", 5 },
                    { 66, new DateTime(2025, 10, 14, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(896), null, null, null, 4, 9, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut ", 6 },
                    { 67, new DateTime(2025, 11, 23, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(900), null, null, null, 5, 6, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing e", 7 },
                    { 68, new DateTime(2025, 9, 18, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(905), null, null, null, 3, 9, 7, 0, "Lorem ipsum dolor sit amet, consecte", 9 },
                    { 69, new DateTime(2025, 10, 8, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(910), null, null, null, 2, 5, 3, 1, "Lorem ipsum dolor sit amet, consectetur a", 4 },
                    { 70, new DateTime(2025, 10, 16, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(915), null, null, null, 0, 9, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididu", 5 },
                    { 71, new DateTime(2025, 10, 23, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(920), null, null, null, 4, 8, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod te", 8 },
                    { 72, new DateTime(2025, 9, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(925), null, null, null, 5, 8, 9, 2, "Lorem ipsum dolor sit amet, consec", 2 },
                    { 73, new DateTime(2025, 9, 18, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(930), null, null, null, 3, 4, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing eli", 4 },
                    { 74, new DateTime(2025, 10, 28, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(934), null, null, null, 2, 8, 6, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmo", 6 },
                    { 75, new DateTime(2025, 10, 7, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(938), null, null, null, 2, 2, 5, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod", 2 },
                    { 76, new DateTime(2025, 11, 1, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1004), null, null, null, 2, 4, 6, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempo", 1 },
                    { 77, new DateTime(2025, 9, 22, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1010), null, null, null, 0, 4, 8, 1, "Lorem ipsum dolor sit amet, consectetur", 8 },
                    { 78, new DateTime(2025, 9, 8, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1015), null, null, null, 5, 4, 8, 2, "Lorem ipsum dolor sit amet,", 3 },
                    { 79, new DateTime(2025, 11, 3, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1019), null, null, null, 4, 9, 2, 0, "Lorem ipsum dolor sit ame", 2 },
                    { 80, new DateTime(2025, 11, 13, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1023), null, null, null, 5, 5, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiu", 9 },
                    { 81, new DateTime(2025, 10, 3, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1028), null, null, null, 4, 7, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor in", 1 },
                    { 82, new DateTime(2025, 11, 5, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1034), null, null, null, 5, 5, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eius", 5 },
                    { 83, new DateTime(2025, 9, 8, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1042), null, null, null, 2, 2, 4, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing el", 1 },
                    { 84, new DateTime(2025, 9, 14, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1050), null, null, null, 3, 2, 3, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp", 1 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreateDate", "DeleteReason", "DeletedAt", "DeletedBy", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[,]
                {
                    { 85, new DateTime(2025, 8, 29, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1056), null, null, null, 3, 5, 9, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tem", 5 },
                    { 86, new DateTime(2025, 9, 12, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1062), null, null, null, 4, 7, 5, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt", 2 },
                    { 87, new DateTime(2025, 10, 14, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1067), null, null, null, 1, 1, 9, 2, "Lorem ipsum dolor sit amet, consectetu", 5 },
                    { 88, new DateTime(2025, 10, 7, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1071), null, null, null, 3, 7, 5, 2, "Lorem ipsum dolor sit amet, consectetur adipisicin", 5 },
                    { 89, new DateTime(2025, 10, 22, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1076), null, null, null, 2, 3, 9, 1, "Lorem ipsum dolor sit ", 1 },
                    { 90, new DateTime(2025, 11, 15, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1086), null, null, null, 0, 5, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipisici", 5 },
                    { 91, new DateTime(2025, 10, 23, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1090), null, null, null, 3, 7, 6, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed d", 7 },
                    { 92, new DateTime(2025, 8, 31, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1095), null, null, null, 3, 2, 6, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inc", 7 },
                    { 93, new DateTime(2025, 8, 24, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1099), null, null, null, 2, 3, 8, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labo", 8 },
                    { 94, new DateTime(2025, 9, 26, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1103), null, null, null, 2, 3, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisici", 7 },
                    { 95, new DateTime(2025, 10, 28, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1108), null, null, null, 4, 8, 2, 0, "Lorem ipsum dolor sit amet, consect", 1 },
                    { 96, new DateTime(2025, 9, 13, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1111), null, null, null, 5, 9, 4, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing e", 7 },
                    { 97, new DateTime(2025, 9, 17, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1115), null, null, null, 5, 8, 9, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inci", 6 },
                    { 98, new DateTime(2025, 10, 27, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1120), null, null, null, 5, 5, 9, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod t", 6 },
                    { 99, new DateTime(2025, 10, 7, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1124), null, null, null, 3, 1, 3, 1, "Lorem ipsum dolor sit a", 8 },
                    { 100, new DateTime(2025, 9, 2, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1130), null, null, null, 2, 1, 8, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut l", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RatingId",
                table: "Reviews",
                column: "RatingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Ratings");
        }
    }
}
