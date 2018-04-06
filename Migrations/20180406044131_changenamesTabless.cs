using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApiMonitoreo.Migrations
{
    public partial class changenamesTabless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "usuarios");

            migrationBuilder.RenameTable(
                name: "mensaje",
                newName: "mensajes");

            migrationBuilder.RenameTable(
                name: "grupousuario",
                newName: "grupousuarios");

            migrationBuilder.RenameTable(
                name: "grupo",
                newName: "grupos");

            migrationBuilder.RenameIndex(
                name: "IX_mensaje_UsuarioID",
                table: "mensajes",
                newName: "IX_mensajes_UsuarioID");

            migrationBuilder.RenameIndex(
                name: "IX_mensaje_GrupoId",
                table: "mensajes",
                newName: "IX_mensajes_GrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_grupousuario_UsuarioId",
                table: "grupousuarios",
                newName: "IX_grupousuarios_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mensajes",
                table: "mensajes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_grupousuarios",
                table: "grupousuarios",
                columns: new[] { "GrupoId", "UsuarioId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_grupos",
                table: "grupos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_grupousuarios_grupos_GrupoId",
                table: "grupousuarios",
                column: "GrupoId",
                principalTable: "grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_grupousuarios_usuarios_UsuarioId",
                table: "grupousuarios",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mensajes_grupos_GrupoId",
                table: "mensajes",
                column: "GrupoId",
                principalTable: "grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mensajes_usuarios_UsuarioID",
                table: "mensajes",
                column: "UsuarioID",
                principalTable: "usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_grupousuarios_grupos_GrupoId",
                table: "grupousuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_grupousuarios_usuarios_UsuarioId",
                table: "grupousuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_mensajes_grupos_GrupoId",
                table: "mensajes");

            migrationBuilder.DropForeignKey(
                name: "FK_mensajes_usuarios_UsuarioID",
                table: "mensajes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mensajes",
                table: "mensajes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_grupousuarios",
                table: "grupousuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_grupos",
                table: "grupos");

            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "usuario");

            migrationBuilder.RenameTable(
                name: "mensajes",
                newName: "mensaje");

            migrationBuilder.RenameTable(
                name: "grupousuarios",
                newName: "grupousuario");

            migrationBuilder.RenameTable(
                name: "grupos",
                newName: "grupo");

            migrationBuilder.RenameIndex(
                name: "IX_mensajes_UsuarioID",
                table: "mensaje",
                newName: "IX_mensaje_UsuarioID");

            migrationBuilder.RenameIndex(
                name: "IX_mensajes_GrupoId",
                table: "mensaje",
                newName: "IX_mensaje_GrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_grupousuarios_UsuarioId",
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
    }
}
