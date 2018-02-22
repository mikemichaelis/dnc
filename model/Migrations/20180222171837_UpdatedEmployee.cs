using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace model.Migrations
{
    public partial class UpdatedEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Employee",
                newName: "zip");

            migrationBuilder.AddColumn<string>(
                name: "address1",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address2",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "hireDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "middleName",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "state",
                table: "Employee",
                nullable: true);

            migrationBuilder.Sql(@"insert into Employee ( firstName, lastName, address1, city, state, zip, country, phone ) 
            values ('Mike', 'Michaelis', '7143 Doris Dr.', 'Indianapolis', 'IN', '46214', 'USA', '+1(317) 699-2111' )");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address1",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "address2",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "country",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "firstName",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "hireDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "middleName",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "state",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "zip",
                table: "Employee",
                newName: "name");
        }
    }
}
