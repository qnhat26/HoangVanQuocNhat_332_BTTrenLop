using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoangVanQuocNhat_BTTrenLop.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DangKyKhoaHocs_KhoaHocs_maKh",
                table: "DangKyKhoaHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_DangKyKhoaHocs_SinhViens_maSv",
                table: "DangKyKhoaHocs");

            migrationBuilder.DropIndex(
                name: "IX_DangKyKhoaHocs_maKh",
                table: "DangKyKhoaHocs");

            migrationBuilder.DropIndex(
                name: "IX_DangKyKhoaHocs_maSv",
                table: "DangKyKhoaHocs");

            migrationBuilder.DropColumn(
                name: "hoTen",
                table: "SinhViens");

            migrationBuilder.DropColumn(
                name: "maKh",
                table: "DangKyKhoaHocs");

            migrationBuilder.DropColumn(
                name: "maSv",
                table: "DangKyKhoaHocs");

            migrationBuilder.RenameColumn(
                name: "maSv",
                table: "SinhViens",
                newName: "msv");

            migrationBuilder.RenameColumn(
                name: "maKh",
                table: "KhoaHocs",
                newName: "mkh");

            migrationBuilder.AddColumn<string>(
                name: "ten",
                table: "SinhViens",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "tenKH",
                table: "KhoaHocs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "mkh",
                table: "DangKyKhoaHocs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "msv",
                table: "DangKyKhoaHocs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DangKyKhoaHocs_mkh",
                table: "DangKyKhoaHocs",
                column: "mkh");

            migrationBuilder.CreateIndex(
                name: "IX_DangKyKhoaHocs_msv",
                table: "DangKyKhoaHocs",
                column: "msv");

            migrationBuilder.AddForeignKey(
                name: "FK_DangKyKhoaHocs_KhoaHocs_mkh",
                table: "DangKyKhoaHocs",
                column: "mkh",
                principalTable: "KhoaHocs",
                principalColumn: "mkh");

            migrationBuilder.AddForeignKey(
                name: "FK_DangKyKhoaHocs_SinhViens_msv",
                table: "DangKyKhoaHocs",
                column: "msv",
                principalTable: "SinhViens",
                principalColumn: "msv");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DangKyKhoaHocs_KhoaHocs_mkh",
                table: "DangKyKhoaHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_DangKyKhoaHocs_SinhViens_msv",
                table: "DangKyKhoaHocs");

            migrationBuilder.DropIndex(
                name: "IX_DangKyKhoaHocs_mkh",
                table: "DangKyKhoaHocs");

            migrationBuilder.DropIndex(
                name: "IX_DangKyKhoaHocs_msv",
                table: "DangKyKhoaHocs");

            migrationBuilder.DropColumn(
                name: "ten",
                table: "SinhViens");

            migrationBuilder.DropColumn(
                name: "mkh",
                table: "DangKyKhoaHocs");

            migrationBuilder.DropColumn(
                name: "msv",
                table: "DangKyKhoaHocs");

            migrationBuilder.RenameColumn(
                name: "msv",
                table: "SinhViens",
                newName: "maSv");

            migrationBuilder.RenameColumn(
                name: "mkh",
                table: "KhoaHocs",
                newName: "maKh");

            migrationBuilder.AddColumn<string>(
                name: "hoTen",
                table: "SinhViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "tenKH",
                table: "KhoaHocs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "maKh",
                table: "DangKyKhoaHocs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "maSv",
                table: "DangKyKhoaHocs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_DangKyKhoaHocs_maKh",
                table: "DangKyKhoaHocs",
                column: "maKh");

            migrationBuilder.CreateIndex(
                name: "IX_DangKyKhoaHocs_maSv",
                table: "DangKyKhoaHocs",
                column: "maSv");

            migrationBuilder.AddForeignKey(
                name: "FK_DangKyKhoaHocs_KhoaHocs_maKh",
                table: "DangKyKhoaHocs",
                column: "maKh",
                principalTable: "KhoaHocs",
                principalColumn: "maKh",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DangKyKhoaHocs_SinhViens_maSv",
                table: "DangKyKhoaHocs",
                column: "maSv",
                principalTable: "SinhViens",
                principalColumn: "maSv",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
