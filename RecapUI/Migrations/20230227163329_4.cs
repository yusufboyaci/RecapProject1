using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecapUI.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Username = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Surname = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Gender = table.Column<char>(type: "character(1)", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: true),
                    MasterId = table.Column<Guid>(type: "uuid", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    OluşturulmaZamanı = table.Column<DateTime>(name: "Oluşturulma Zamanı", type: "timestamp with time zone", nullable: false),
                    OluşturanIp = table.Column<string>(name: "Oluşturan Ip", type: "text", nullable: true),
                    OluşturanKişi = table.Column<string>(name: "Oluşturan Kişi", type: "text", nullable: true),
                    OluşturanınBilgisayarAdı = table.Column<string>(name: "Oluşturanın Bilgisayar Adı", type: "text", nullable: true),
                    OluşturanYöneticiAdı = table.Column<string>(name: "Oluşturan Yönetici Adı", type: "text", nullable: true),
                    OluşturanınBilgisayarınınDomainAdı = table.Column<string>(name: "Oluşturanın Bilgisayarının Domain Adı", type: "text", nullable: true),
                    GüncelleyenZamanı = table.Column<DateTime>(name: "Güncelleyen Zamanı", type: "timestamp with time zone", nullable: false),
                    GüncelleyenIp = table.Column<string>(name: "Güncelleyen Ip", type: "text", nullable: true),
                    GüncelleyenKişi = table.Column<string>(name: "Güncelleyen Kişi", type: "text", nullable: true),
                    GüncelleyenBilgisayarAdı = table.Column<string>(name: "Güncelleyen Bilgisayar Adı", type: "text", nullable: true),
                    GüncelleyenYöneticiAdı = table.Column<string>(name: "Güncelleyen Yönetici Adı", type: "text", nullable: true),
                    GüncelleyenBilgisayarınınDomainAdı = table.Column<string>(name: "Güncelleyen Bilgisayarının Domain Adı", type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
