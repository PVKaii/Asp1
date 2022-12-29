using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleEntityUserEntity_Role_RolesId",
                table: "RoleEntityUserEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleEntityUserEntity_User_UsersId",
                table: "RoleEntityUserEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleEntityUserEntity",
                table: "RoleEntityUserEntity");

            migrationBuilder.RenameTable(
                name: "RoleEntityUserEntity",
                newName: "UserRole");

            migrationBuilder.RenameIndex(
                name: "IX_RoleEntityUserEntity_UsersId",
                table: "UserRole",
                newName: "IX_UserRole_UsersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                columns: new[] { "RolesId", "UsersId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_RolesId",
                table: "UserRole",
                column: "RolesId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UsersId",
                table: "UserRole",
                column: "UsersId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Role_RolesId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_UsersId",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "RoleEntityUserEntity");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_UsersId",
                table: "RoleEntityUserEntity",
                newName: "IX_RoleEntityUserEntity_UsersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleEntityUserEntity",
                table: "RoleEntityUserEntity",
                columns: new[] { "RolesId", "UsersId" });

            migrationBuilder.AddForeignKey(
                name: "FK_RoleEntityUserEntity_Role_RolesId",
                table: "RoleEntityUserEntity",
                column: "RolesId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleEntityUserEntity_User_UsersId",
                table: "RoleEntityUserEntity",
                column: "UsersId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
