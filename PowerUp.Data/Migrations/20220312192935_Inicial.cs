using System;
using Microsoft.EntityFrameworkCore.Migrations;
using PowerUp.Domain.Core.Enums;

#nullable disable

namespace PowerUp.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstacoesRecargas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstacoesRecargas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EstacoesRecargas",
                columns: new[] { "Id", "Nome", "Tipo", "Latitude", "Longitude", "DataCriacao" },
                values: new object[,]
                {
                    { Guid.NewGuid(), "Infnet", (int) Tipo.Movel, -22.905895419011326, -43.17685031645948, DateTime.Now },
                    { Guid.NewGuid(), "Terminal CCR Barcas Praça XV", (int) Tipo.Movel, -22.902321889230684, -43.172456727584866, DateTime.Now },
                    { Guid.NewGuid(), "Praça XV", (int) Tipo.Movel, -22.901981167412888, -43.17303412236401, DateTime.Now },
                    { Guid.NewGuid(), "Museu do Amanhã", (int) Tipo.Movel, -22.89437670024632, -43.17962902189141, DateTime.Now },
                    { Guid.NewGuid(), "Boulevard Olímpico", (int) Tipo.Veicular, -22.895440516638693, -43.1803688301861, DateTime.Now },
                    { Guid.NewGuid(), "Museu de Arte do Rio - MAR", (int) Tipo.Movel, -22.896487687437585, -43.18167699844458, DateTime.Now },
                    { Guid.NewGuid(), "Candelária", (int) Tipo.Veicular, -22.90152407423211, -43.17887121337721, DateTime.Now },
                    { Guid.NewGuid(), "Castelo", (int) Tipo.Veicular, -22.905895419011326, -43.17685031645948, DateTime.Now },
                    { Guid.NewGuid(), "Marina da Glória", (int) Tipo.Veicular, -22.918737862686857, -43.167845035121246, DateTime.Now }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstacoesRecargas");
        }
    }
}
