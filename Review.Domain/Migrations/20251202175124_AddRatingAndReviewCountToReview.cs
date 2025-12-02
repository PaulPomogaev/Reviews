using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Review.Domain.Migrations
{
    public partial class AddRatingAndReviewCountToReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Ratings_RatingId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_RatingId",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "RatingId",
                table: "Reviews",
                newName: "ReviewCount");

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Reviews",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 13, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7129), 5, 1, 4.1699999999999999, 6, 2, "Lorem ipsum dolor sit amet, consectetur ad", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 18, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7175), 3, 8, 3.71, 7, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod te", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 12, 1, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7182), 1, 7, 2.1699999999999999, 6, 1, "Lorem ipsum dolor sit", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 8, 27, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7186), 7, 2.1699999999999999, 6, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 24, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7191), 5, 1, 4.1699999999999999, 6, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut ", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 30, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7199), 4, 6, 3.1000000000000001, 10, 0, "Lorem ipsum dolor sit amet, consec", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 11, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7204), 1, 1, 4.1699999999999999, 6, "Lorem ipsum dolor sit amet, consectetur ", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 30, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7208), 2, 6, 3.1000000000000001, 10, "Lorem ipsum dolor sit am", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 22, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7212), 3, 8, 3.71, 7, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tem", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text" },
                values: new object[] { new DateTime(2025, 9, 4, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7219), 5, 3, 3.75, 8, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 17, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7224), 1, 1, 4.1699999999999999, 6, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 28, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7229), 4, 2, 3.71, 7, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut la", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Grade", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 10, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7232), 3, 3.2200000000000002, 9, 1, "Lorem ipsum dolor sit amet, consectetur a", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 29, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7237), 6, 3.1000000000000001, 10, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmo", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 18, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7241), 5, 8, 3.71, 7, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 25, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7245), 4, 3, 3.75, 8, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 28, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7250), 2, 8, 3.71, 7, 2, "Lorem ipsum dolor sit ame", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 21, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7257), 5, 2, 3.71, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididu", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 7, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7262), 5, 8, 3.71, 7, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 16, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7266), 4, 5, 2.9199999999999999, 12, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 22, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7270), 5, 5, 2.9199999999999999, 12, "Lorem ipsum dolor sit amet,", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 6, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7275), 5, 2.9199999999999999, 12, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed ", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 19, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7279), 5, 1, 4.1699999999999999, 6, 1, "Lorem ipsum dolor sit amet", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 7, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7283), 4, 9, 3.2200000000000002, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incid", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 6, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7365), 3, 7, 2.1699999999999999, 6, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 25, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7371), 3, 5, 2.9199999999999999, 12, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut ", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 15, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7375), 5, 3, 3.75, 8, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 2, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7378), 5, 5, 2.9199999999999999, 12, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 29, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7384), 1, 5, 2.9199999999999999, 12, "Lorem ipsum dolor sit a", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 18, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7389), 4, 2, 3.71, 7, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing el", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 29, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7394), 3, 9, 3.2200000000000002, 9, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiu", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 29, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7398), 5, 9, 3.2200000000000002, 9, 1, "Lorem ipsum dolor sit amet, consectetur adi", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateDate", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 1, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7402), 4, 3.4300000000000002, 7, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing el", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text" },
                values: new object[] { new DateTime(2025, 11, 13, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7410), 5, 8, 3.71, 7, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 10, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7413), 4, 5, 2.9199999999999999, 12, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateDate", "Grade", "Rating", "ReviewCount", "Status", "Text" },
                values: new object[] { new DateTime(2025, 8, 24, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7417), 1, 3.2200000000000002, 9, 1, "Lorem ipsum dolor sit amet, consectetur" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 29, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7421), 5, 3, 3.75, 8, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labor", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateDate", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 8, 30, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7425), 5, 2.9199999999999999, 12, 1, "Lorem ipsum dolor sit amet", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 8, 30, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7429), 5, 3, 3.75, 8, 2, "Lorem ipsum dolor sit amet,", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 8, 30, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7434), 4, 2, 3.71, 7, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempo", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text" },
                values: new object[] { new DateTime(2025, 11, 22, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7438), 5, 3, 3.75, 8, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididu" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 25, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7442), 5, 1, 4.1699999999999999, 6, 2, "Lorem ipsum dolor sit amet", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 19, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7446), 3, 2, 3.71, 7, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 15, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7449), 5, 8, 3.71, 7, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inci", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 17, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7453), 3, 2, 3.71, 7, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor in", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 8, 27, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7457), 2, 5, 2.9199999999999999, 12, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateDate", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 24, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7461), 6, 3.1000000000000001, 10, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do ei", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateDate", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 28, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7465), 6, 3.1000000000000001, 10, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing eli", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateDate", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 8, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7469), 3, 3.75, 8, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateDate", "Grade", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 3, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7473), 5, 3.1000000000000001, 10, 0, "Lorem ipsum dolor sit amet, consectetu", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text" },
                values: new object[] { new DateTime(2025, 11, 9, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7476), 3, 5, 2.9199999999999999, 12, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 4, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7480), 5, 2, 3.71, 7, 0, "Lorem ipsum dolor sit ", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 6, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7484), 1, 8, 3.71, 7, 1, "Lorem ipsum dolor sit amet, consectetur ad", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 17, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7487), 4, 6, 3.1000000000000001, 10, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do ", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 24, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7590), 3, 3, 3.75, 8, 0, "Lorem ipsum dolor sit amet, consectet", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 29, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7597), 2, 1, 4.1699999999999999, 6, 2, "Lorem ipsum dolor sit am", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateDate", "ProductId", "Rating", "ReviewCount", "Status", "Text" },
                values: new object[] { new DateTime(2025, 10, 15, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7602), 7, 2.1699999999999999, 6, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 8, 25, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7606), 2, 2, 3.71, 7, "Lorem ipsum dolor sit amet", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 6, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7610), 4, 8, 3.71, 7, 1, "Lorem ipsum dolor sit amet, consectetur adipisicin", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 19, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7613), 4, 3, 3.75, 8, "Lorem ipsum dolor sit amet, consectetur ad", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 17, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7618), 4, 9, 3.2200000000000002, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 10, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7623), 3, 4, 3.4300000000000002, 7, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut la", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 23, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7627), 4, 5, 2.9199999999999999, 12, 1, "Lorem ipsum dolor sit amet,", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 29, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7631), 5, 1, 4.1699999999999999, 6, 1, "Lorem ipsum dolor sit amet, consecte", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 17, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7635), 2, 5, 2.9199999999999999, 12, 1, "Lorem ipsum dolor sit amet, consectetur adipi", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 23, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7643), 2, 5, 2.9199999999999999, 12, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit,", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text" },
                values: new object[] { new DateTime(2025, 11, 12, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7648), 3, 3, 3.75, 8, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do ei" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 12, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7652), 5, 4, 3.4300000000000002, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tem", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateDate", "Grade", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 19, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7656), 3, 2.9199999999999999, 12, "Lorem ipsum dolor sit amet, consectetur adipis", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 25, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7660), 4, 4, 3.4300000000000002, 7, 2, "Lorem ipsum dolor sit amet, consectetur", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 23, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7664), 3, 1, 4.1699999999999999, 6, 1, "Lorem ipsum dolor sit ", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 3, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7668), 1, 4, 3.4300000000000002, 7, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt u", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateDate", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 6, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7671), 3, 3.75, 8, 2, "Lorem ipsum dolor sit amet, cons", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 3, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7676), 4, 9, 3.2200000000000002, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidi", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 26, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7681), 1, 4, 3.4300000000000002, 7, 1, "Lorem ipsum dolor sit amet, consect", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 5, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7685), 4, 1, 4.1699999999999999, "Lorem ipsum dolor sit amet, consectetu", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 7, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7689), 4, 6, 3.1000000000000001, 10, "Lorem ipsum dolor sit amet, consectetur adipisicin", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 23, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7694), 3, 9, 3.2200000000000002, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 25, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7697), 3, 3, 3.75, 8, 2, "Lorem ipsum dolor sit amet, consectetur adipisici", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateDate", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 12, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7702), 1, 4.1699999999999999, 6, "Lorem ipsum dolor sit amet, consectetur adipisicing", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 19, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7705), 3, 3, 3.75, 8, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut l", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 8, 31, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7709), 2, 7, 2.1699999999999999, 6, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor ", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 29, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7715), 1, 8, 3.71, 7, "Lorem ipsum dolor sit amet, cons", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text" },
                values: new object[] { new DateTime(2025, 10, 18, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7718), 2, 1, 4.1699999999999999, 6, 1, "Lorem ipsum dolor sit amet, cons" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateDate", "ProductId", "Rating", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 5, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7722), 9, 3.2200000000000002, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 10, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7776), 2, 1, 4.1699999999999999, 6, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 5, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7782), 4, 4, 3.4300000000000002, 7, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inc", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreateDate", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 21, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7786), 5, 2.9199999999999999, 12, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod te", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreateDate", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 15, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7790), 3.75, 8, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do ", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 4, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7795), 5, 4, 3.4300000000000002, 7, 0, "Lorem ipsum dolor sit amet, consectetur ", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 24, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7799), 5, 4, 3.4300000000000002, 7, 2, "Lorem ipsum dolor sit amet, consectetur adipisici", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateDate", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 30, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(7804), 9, 3.2200000000000002, 9, "Lorem ipsum dolor sit amet, consectet", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 13, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(8054), 1, 6, 3.1000000000000001, 10, 1, "Lorem ipsum dolor sit amet, consectetur", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 3, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(8059), 3, 9, 3.2200000000000002, 2, "Lorem ipsum dolor sit ", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 30, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(8063), 2, 6, 3.1000000000000001, 10, "Lorem ipsum dolor sit amet, consectetu", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreateDate", "Grade", "Rating", "ReviewCount", "Status", "Text" },
                values: new object[] { new DateTime(2025, 10, 8, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(8067), 3, 3.2200000000000002, 9, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eius" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreateDate", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 2, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(8071), 4, 3.4300000000000002, 7, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateDate", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 12, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(8075), 1, 4.1699999999999999, 6, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do ", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 24, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(8078), 2, 7, 2.1699999999999999, 6, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiu", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Rating", "ReviewCount", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 15, 21, 51, 21, 332, DateTimeKind.Local).AddTicks(8082), 4, 5, 2.9199999999999999, 12, 2, "Lorem ipsum dolor sit amet, consect", 9 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "ReviewCount",
                table: "Reviews",
                newName: "RatingId");

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Grade = table.Column<double>(type: "float", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                });

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
                    { 41, new DateTime(2025, 9, 11, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3342), 3.5, 2 },
                    { 42, new DateTime(2025, 9, 9, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(3455), 2.5, 8 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CreateDate", "Grade", "ProductId" },
                values: new object[,]
                {
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
                    { 83, new DateTime(2025, 10, 30, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5222), 4.0, 7 },
                    { 84, new DateTime(2025, 10, 20, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(5239), 2.0, 8 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CreateDate", "Grade", "ProductId" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 30, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(614), 1, 9, 2, "Lorem ipsum dolor sit amet, consectetur ad", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 22, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(872), 5, 7, 0, "Lorem ipsum dolor si", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 18, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(905), 3, 9, 0, "Lorem ipsum dolor sit amet, consecte", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 1, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1004), 2, 4, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempo", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateDate", "ProductId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 8, 29, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1056), 5, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tem", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreateDate", "Grade", "ProductId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 26, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1103), 2, 3, 1, "Lorem ipsum dolor sit amet, consectetur adipisici", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 27, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(342), 3, 5, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusm", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 5, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(393), 5, 9, 3, 2, "Lorem ipsum dolor sit amet, con", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 21, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(401), 3, 9, 8, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut la", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 11, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(405), 5, 3, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 14, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(412), 2, 2, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing ", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 8, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(416), 1, 4, 6, 2, "Lorem ipsum dolor sit amet, consectetur adipisicin", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 28, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(420), 3, 7, 8, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididun", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 8, 30, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(565), 4, 9, 3, "Lorem ipsum dolor sit amet, consec", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 10, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(572), 2, 6, 2, "Lorem ipsum dolor sit amet, consectetur adipisicin", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text" },
                values: new object[] { new DateTime(2025, 11, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(576), 0, 9, 3, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(580), 2, 8, 8, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labor", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(585), 3, 4, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "Grade", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 11, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(590), 0, 2, 2, "Lorem ipsum dolor sit amet, consectetur adipisi", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 4, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(594), 5, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusm", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 24, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(599), 4, 5, 1, 0, "Lorem ipsum dolor sit ", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 17, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(604), 2, 4, 4, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed d", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 9, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(608), 0, 2, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed d", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 3, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(619), 2, 5, 8, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut l", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 24, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(624), 0, 4, 5, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 11, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(628), 0, 6, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmo", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 10, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(633), 3, 7, 1, "Lorem ipsum dolor sit amet", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 4, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(637), 2, 6, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 3, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(641), 3, 3, 5, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 8, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(645), 4, 5, 7, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 7, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(650), 5, 7, 1, 2, "Lorem ipsum dolor sit amet, consectetur adip", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 5, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(655), 3, 8, 3, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eius", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 29, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(660), 2, 6, 3, 1, "Lorem ipsum dolor sit amet, co", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 9, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(664), 5, 2, 7, "Lorem ipsum dolor si", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(669), 2, 4, 5, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed d", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 31, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(673), 0, 3, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing ", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 29, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(680), 4, 3, 2, 0, "Lorem ipsum dolor sit amet, cons", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateDate", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 10, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(685), 5, 9, 2, "Lorem ipsum dolor sit", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text" },
                values: new object[] { new DateTime(2025, 10, 9, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(690), 1, 4, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipi" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 2, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(695), 2, 3, 4, 2, "Lorem ipsum dolor sit", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateDate", "Grade", "RatingId", "Status", "Text" },
                values: new object[] { new DateTime(2025, 9, 13, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(699), 3, 8, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 12, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(703), 2, 4, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut la", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateDate", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(707), 2, 9, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 22, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(715), 3, 7, 5, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 10, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(721), 2, 6, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisi", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text" },
                values: new object[] { new DateTime(2025, 9, 29, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(724), 3, 2, 9, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inci" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 1, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(784), 2, 6, 2, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 12, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(791), 1, 9, 3, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed ", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 23, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(794), 0, 2, 4, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusm", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 8, 29, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(799), 4, 5, 4, "Lorem ipsum dolor sit amet, consectetur ad", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 8, 28, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(803), 5, 2, 6, "Lorem ipsum dolor sit amet, consectetur adipisicin", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateDate", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 7, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(808), 2, 4, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateDate", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 29, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(813), 5, 7, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod ", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateDate", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 27, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(818), 6, 1, 2, "Lorem ipsum dolor sit", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateDate", "Grade", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 15, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(822), 0, 3, 2, "Lorem ipsum dolor sit amet, co", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text" },
                values: new object[] { new DateTime(2025, 10, 18, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(828), 4, 2, 3, 0, "Lorem ipsum dolor sit amet, consectet" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 24, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(832), 4, 1, 1, 1, "Lorem ipsum dolor sit amet,", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(838), 5, 3, 3, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 8, 25, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(842), 3, 2, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod te", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 4, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(846), 0, 2, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 14, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(851), 3, 4, 5, 1, "Lorem ipsum dolor sit amet, consectetur ad", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateDate", "ProductId", "RatingId", "Status", "Text" },
                values: new object[] { new DateTime(2025, 9, 8, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(855), 6, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inci" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 20, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(859), 5, 9, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 15, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(863), 1, 3, 6, 0, "Lorem ipsum dolor sit amet, consectetur a", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 9, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(868), 3, 6, 3, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt u", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 4, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(877), 5, 1, 3, 2, "Lorem ipsum dolor sit amet, consectetur adipisici", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 7, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(883), 0, 3, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labor", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 27, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(888), 2, 7, 7, 0, "Lorem ipsum dolor sit amet", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 14, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(891), 3, 6, 7, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 14, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(896), 4, 9, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut ", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text" },
                values: new object[] { new DateTime(2025, 11, 23, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(900), 5, 6, 4, "Lorem ipsum dolor sit amet, consectetur adipisicing e" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateDate", "Grade", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 8, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(910), 2, 3, "Lorem ipsum dolor sit amet, consectetur a", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 16, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(915), 0, 9, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididu", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 23, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(920), 4, 8, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod te", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 19, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(925), 5, 8, 9, 2, "Lorem ipsum dolor sit amet, consec", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateDate", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 18, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(930), 4, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing eli", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 28, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(934), 2, 8, 6, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmo", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 7, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(938), 2, 2, 5, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 22, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1010), 0, 4, 8, "Lorem ipsum dolor sit amet, consectetur", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 8, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1015), 5, 4, 8, 2, "Lorem ipsum dolor sit amet,", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 3, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1019), 4, 9, 2, 0, "Lorem ipsum dolor sit ame", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateDate", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1023), 5, 4, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiu", 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 3, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1028), 4, 7, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor in", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 5, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1034), 5, 5, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eius", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 8, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1042), 2, 2, 4, "Lorem ipsum dolor sit amet, consectetur adipisicing el", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text" },
                values: new object[] { new DateTime(2025, 9, 14, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1050), 3, 2, 3, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 12, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1062), 4, 7, 5, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 14, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1067), 1, 1, 9, 2, "Lorem ipsum dolor sit amet, consectetu", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreateDate", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 7, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1071), 7, 5, 2, "Lorem ipsum dolor sit amet, consectetur adipisicin", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreateDate", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 22, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1076), 9, "Lorem ipsum dolor sit ", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 11, 15, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1086), 0, 5, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipisici", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 23, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1090), 3, 7, 6, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed d", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateDate", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 8, 31, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1095), 2, 6, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inc", 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 8, 24, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1099), 2, 3, 8, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labo", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 28, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1108), 4, 8, 2, "Lorem ipsum dolor sit amet, consect", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreateDate", "Grade", "RatingId", "Status", "Text" },
                values: new object[] { new DateTime(2025, 9, 13, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1111), 5, 4, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing e" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreateDate", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 17, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1115), 8, 9, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inci", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateDate", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 27, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1120), 5, 9, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod t", 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 10, 7, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1124), 3, 1, 3, "Lorem ipsum dolor sit a", 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[] { new DateTime(2025, 9, 2, 17, 25, 27, 950, DateTimeKind.Local).AddTicks(1130), 2, 1, 8, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut l", 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RatingId",
                table: "Reviews",
                column: "RatingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Ratings_RatingId",
                table: "Reviews",
                column: "RatingId",
                principalTable: "Ratings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
