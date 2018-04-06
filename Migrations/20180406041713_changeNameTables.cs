using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApiMonitoreo.Migrations
{
    public partial class changeNameTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GruposUsuarios_Grupos_GrupoId",
                table: "GruposUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_GruposUsuarios_Usuarios_UsuarioId",
                table: "GruposUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Grupos_GrupoId",
                table: "Mensajes");

            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_Usuarios_UsuarioID",
                table: "Mensajes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mensajes",
                table: "Mensajes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GruposUsuarios",
                table: "GruposUsuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grupos",
                table: "Grupos");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "usuario");

            migrationBuilder.RenameTable(
                name: "Mensajes",
                newName: "mensaje");

            migrationBuilder.RenameTable(
                name: "GruposUsuarios",
                newName: "grupousuario");

            migrationBuilder.RenameTable(
                name: "Grupos",
                newName: "grupo");

            migrationBuilder.RenameIndex(
                name: "IX_Mensajes_UsuarioID",
                table: "mensaje",
                newName: "IX_mensaje_UsuarioID");

            migrationBuilder.RenameIndex(
                name: "IX_Mensajes_GrupoId",
                table: "mensaje",
                newName: "IX_mensaje_GrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_GruposUsuarios_UsuarioId",
                table: "grupousuario",
                newName: "IX_grupousuario_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuario",
                table: "usuario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mensaje",
                table: "mensaje",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_grupousuario",
                table: "grupousuario",
                columns: new[] { "GrupoId", "UsuarioId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_grupo",
                table: "grupo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_grupousuario_grupo_GrupoId",
                table: "grupousuario",
                column: "GrupoId",
                principalTable: "grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_grupousuario_usuario_UsuarioId",
                table: "grupousuario",
                column: "UsuarioId",
                principalTable: "usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mensaje_grupo_GrupoId",
                table: "mensaje",
                column: "GrupoId",
                principalTable: "grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mensaje_usuario_UsuarioID",
                table: "mensaje",
                column: "UsuarioID",
                principalTable: "usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_grupousuario_grupo_GrupoId",
                table: "grupousuario");

            migrationBuilder.DropForeignKey(
                name: "FK_grupousuario_usuario_UsuarioId",
                table: "grupousuario");

            migrationBuilder.DropForeignKey(
                name: "FK_mensaje_grupo_GrupoId",
                table: "mensaje");

            migrationBuilder.DropForeignKey(
                name: "FK_mensaje_usuario_UsuarioID",
                table: "mensaje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuario",
                table: "usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mensaje",
                table: "mensaje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_grupousuario",
                table: "grupousuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_grupo",
                table: "grupo");

            migrationBuilder.RenameTable(
                name: "usuario",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "mensaje",
                newName: "Mensajes");

            migrationBuilder.RenameTable(
                name: "grupousuario",
                newName: "GruposUsuarios");

            migrationBuilder.RenameTable(
                name: "grupo",
                newName: "Grupos");

            migrationBuilder.RenameIndex(
                name: "IX_mensaje_UsuarioID",
                table: "Mensajes",
                newName: "IX_Mensajes_UsuarioID");

            migrationBuilder.RenameIndex(
                name: "IX_mensaje_GrupoId",
                table: "Mensajes",
                newName: "IX_Mensajes_GrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_grupousuario_UsuarioId",
                table: "GruposUsuarios",
                newName: "IX_GruposUsuarios_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mensajes",
                table: "Mensajes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GruposUsuarios",
                table: "GruposUsuarios",
                columns: new[] { "GrupoId", "UsuarioId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grupos",
                table: "Grupos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GruposUsuarios_Grupos_GrupoId",
                table: "GruposUsuarios",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GruposUsuarios_Usuarios_UsuarioId",
                table: "GruposUsuarios",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Grupos_GrupoId",
                table: "Mensajes",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mensajes_Usuarios_UsuarioID",
                table: "Mensajes",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
