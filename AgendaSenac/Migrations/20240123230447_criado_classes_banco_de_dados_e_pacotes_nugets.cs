using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaSenac.Migrations
{
    public partial class criado_classes_banco_de_dados_e_pacotes_nugets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgendaCursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Inicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Fim = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Dias = table.Column<string>(type: "TEXT", nullable: false),
                    Meta = table.Column<string>(type: "TEXT", nullable: true),
                    Realizado = table.Column<string>(type: "TEXT", nullable: true),
                    Valor = table.Column<string>(type: "TEXT", nullable: true),
                    Horario = table.Column<string>(type: "TEXT", nullable: true),
                    Turma = table.Column<string>(type: "TEXT", nullable: true),
                    Sala = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendaCursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Historicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Login = table.Column<string>(type: "TEXT", nullable: false),
                    DataHora = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Alteracao = table.Column<string>(type: "TEXT", nullable: false),
                    Detalhes = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Login = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Senha = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Administrador = table.Column<bool>(type: "INTEGER", nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgendaCursos");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Historicos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
