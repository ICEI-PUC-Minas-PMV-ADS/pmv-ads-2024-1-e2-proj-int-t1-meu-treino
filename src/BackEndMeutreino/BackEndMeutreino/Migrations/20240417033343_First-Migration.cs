using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BackEndMeutreino.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "exercicio",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: false),
                    grupoMuscular = table.Column<string>(type: "text", nullable: false),
                    imagem = table.Column<string>(type: "text", nullable: false),
                    dificuldade = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercicio", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    senha = table.Column<string>(type: "text", nullable: false),
                    role = table.Column<string>(type: "text", nullable: false),
                    altura = table.Column<double>(type: "double precision", nullable: false),
                    peso = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "avaliacao",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_usuario = table.Column<int>(type: "integer", nullable: false),
                    id_exercicio = table.Column<int>(type: "integer", nullable: false),
                    avaliacao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_avaliacao", x => x.id);
                    table.ForeignKey(
                        name: "FK_avaliacao_exercicio_id_exercicio",
                        column: x => x.id_exercicio,
                        principalTable: "exercicio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_avaliacao_usuario_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "favoritos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_usuario = table.Column<int>(type: "integer", nullable: false),
                    id_exercicio = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_favoritos", x => x.id);
                    table.ForeignKey(
                        name: "FK_favoritos_exercicio_id_exercicio",
                        column: x => x.id_exercicio,
                        principalTable: "exercicio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_favoritos_usuario_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "historicoPeso",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_usuario = table.Column<int>(type: "integer", nullable: false),
                    peso = table.Column<double>(type: "double precision", nullable: false),
                    data = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historicoPeso", x => x.id);
                    table.ForeignKey(
                        name: "FK_historicoPeso_usuario_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_avaliacao_id_exercicio",
                table: "avaliacao",
                column: "id_exercicio");

            migrationBuilder.CreateIndex(
                name: "IX_avaliacao_id_usuario",
                table: "avaliacao",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_favoritos_id_exercicio",
                table: "favoritos",
                column: "id_exercicio");

            migrationBuilder.CreateIndex(
                name: "IX_favoritos_id_usuario",
                table: "favoritos",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_historicoPeso_id_usuario",
                table: "historicoPeso",
                column: "id_usuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "avaliacao");

            migrationBuilder.DropTable(
                name: "favoritos");

            migrationBuilder.DropTable(
                name: "historicoPeso");

            migrationBuilder.DropTable(
                name: "exercicio");

            migrationBuilder.DropTable(
                name: "usuario");
        }
    }
}
