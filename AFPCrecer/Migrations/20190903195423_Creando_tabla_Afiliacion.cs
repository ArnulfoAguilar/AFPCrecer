using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AFPCrecer.Migrations
{
    public partial class Creando_tabla_Afiliacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Afiliacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonaId = table.Column<int>(nullable: false),
                    TipoAfiliacionId = table.Column<int>(nullable: false),
                    fecha_afiliacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afiliacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Afiliacion_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Afiliacion_TipoAfiliacion_TipoAfiliacionId",
                        column: x => x.TipoAfiliacionId,
                        principalTable: "TipoAfiliacion",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Afiliacion_PersonaId",
                table: "Afiliacion",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Afiliacion_TipoAfiliacionId",
                table: "Afiliacion",
                column: "TipoAfiliacionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Afiliacion");
        }
    }
}
