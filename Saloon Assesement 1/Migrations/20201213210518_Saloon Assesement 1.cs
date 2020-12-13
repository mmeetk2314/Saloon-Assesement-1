using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Saloon_Assesement_1.Migrations
{
    public partial class SaloonAssesement1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parlour",
                columns: table => new
                {
                    Parlour_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Parlour_Name = table.Column<string>(nullable: true),
                    Parlour_Address = table.Column<string>(nullable: true),
                    Contact_Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parlour", x => x.Parlour_ID);
                });

            migrationBuilder.CreateTable(
                name: "Beautician",
                columns: table => new
                {
                    Beautician_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Beautician_Name = table.Column<string>(nullable: true),
                    Contact_Number = table.Column<int>(nullable: false),
                    Joining_Date = table.Column<DateTime>(nullable: false),
                    Salary = table.Column<int>(nullable: false),
                    ParlourID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beautician", x => x.Beautician_ID);
                    table.ForeignKey(
                        name: "FK_Beautician_Parlour_ParlourID",
                        column: x => x.ParlourID,
                        principalTable: "Parlour",
                        principalColumn: "Parlour_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Customer_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Name = table.Column<string>(nullable: true),
                    Contact_Number = table.Column<int>(nullable: false),
                    Expenses = table.Column<int>(nullable: false),
                    ParlourID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Customer_ID);
                    table.ForeignKey(
                        name: "FK_Customer_Parlour_ParlourID",
                        column: x => x.ParlourID,
                        principalTable: "Parlour",
                        principalColumn: "Parlour_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Product_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(nullable: true),
                    Expiry_Date = table.Column<DateTime>(nullable: false),
                    ParlourID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Product_ID);
                    table.ForeignKey(
                        name: "FK_Product_Parlour_ParlourID",
                        column: x => x.ParlourID,
                        principalTable: "Parlour",
                        principalColumn: "Parlour_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beautician_ParlourID",
                table: "Beautician",
                column: "ParlourID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ParlourID",
                table: "Customer",
                column: "ParlourID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ParlourID",
                table: "Product",
                column: "ParlourID");
            var sqlFile = Path.Combine(".\\DatabaseScript", @"data.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

    

        
       

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beautician");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Parlour");
        }
    }

    internal struct NewStruct
    {
        public sqlFile Item1;
        public object Item2;

        public NewStruct(sqlFile item1, object item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   EqualityComparer<sqlFile>.Default.Equals(Item1, other.Item1) &&
                   EqualityComparer<object>.Default.Equals(Item2, other.Item2);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Item1, Item2);
        }

        public void Deconstruct(out sqlFile item1, out object item2)
        {
            item1 = Item1;
            item2 = Item2;
        }

        public static implicit operator (sqlFile, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((sqlFile, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}
