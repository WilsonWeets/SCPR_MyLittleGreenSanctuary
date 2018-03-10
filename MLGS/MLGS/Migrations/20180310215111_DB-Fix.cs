using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MLGS.Migrations
{
    public partial class DBFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ParselsData",
                table: "ParselsData");

            migrationBuilder.RenameTable(
                name: "ParselsData",
                newName: "ParcelsData");

            migrationBuilder.RenameColumn(
                name: "Temperature",
                table: "ParcelsData",
                newName: "Temperature_sensor_value");

            migrationBuilder.RenameColumn(
                name: "Pression",
                table: "ParcelsData",
                newName: "Pressure_sensor_value");

            migrationBuilder.RenameColumn(
                name: "Light",
                table: "ParcelsData",
                newName: "Light_sensor_value");

            migrationBuilder.RenameColumn(
                name: "Humidity",
                table: "ParcelsData",
                newName: "Humidity_value");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParcelsData",
                table: "ParcelsData",
                column: "ParcelDataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ParcelsData",
                table: "ParcelsData");

            migrationBuilder.RenameTable(
                name: "ParcelsData",
                newName: "ParselsData");

            migrationBuilder.RenameColumn(
                name: "Temperature_sensor_value",
                table: "ParselsData",
                newName: "Temperature");

            migrationBuilder.RenameColumn(
                name: "Pressure_sensor_value",
                table: "ParselsData",
                newName: "Pression");

            migrationBuilder.RenameColumn(
                name: "Light_sensor_value",
                table: "ParselsData",
                newName: "Light");

            migrationBuilder.RenameColumn(
                name: "Humidity_value",
                table: "ParselsData",
                newName: "Humidity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParselsData",
                table: "ParselsData",
                column: "ParcelDataId");
        }
    }
}
