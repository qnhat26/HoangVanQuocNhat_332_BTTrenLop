using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoangVanQuocNhat_BTTrenLop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhoaHocs",
                columns: table => new
                {
                    maKh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenKH = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHocs", x => x.maKh);
                });

            migrationBuilder.CreateTable(
                name: "SinhViens",
                columns: table => new
                {
                    maSv = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    hoTen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhViens", x => x.maSv);
                });

            migrationBuilder.CreateTable(
                name: "DangKyKhoaHocs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayDK = table.Column<DateTime>(type: "datetime2", nullable: false),
                    maSv = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maKh = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangKyKhoaHocs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DangKyKhoaHocs_KhoaHocs_maKh",
                        column: x => x.maKh,
                        principalTable: "KhoaHocs",
                        principalColumn: "maKh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DangKyKhoaHocs_SinhViens_maSv",
                        column: x => x.maSv,
                        principalTable: "SinhViens",
                        principalColumn: "maSv",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DangKyKhoaHocs_maKh",
                table: "DangKyKhoaHocs",
                column: "maKh");

            migrationBuilder.CreateIndex(
                name: "IX_DangKyKhoaHocs_maSv",
                table: "DangKyKhoaHocs",
                column: "maSv");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DangKyKhoaHocs");

            migrationBuilder.DropTable(
                name: "KhoaHocs");

            migrationBuilder.DropTable(
                name: "SinhViens");
        }
    }
}
