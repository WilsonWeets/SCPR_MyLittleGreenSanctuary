using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MLGS.Migrations
{
    public partial class DBFix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pressure_sensor_value",
                table: "ParcelsData");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Pressure_sensor_value",
                table: "ParcelsData",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
