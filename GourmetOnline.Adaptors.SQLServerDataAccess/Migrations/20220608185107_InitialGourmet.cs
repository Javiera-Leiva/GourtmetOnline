using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GourmetOnline.Adaptors.SQLServerDataAccess.Migrations
{
    public partial class InitialGourmet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Administrador",
                columns: table => new
                {
                    Id_Admin = table.Column<Guid>(nullable: false),
                    Nombre_Admin = table.Column<string>(nullable: true),
                    Correo_Admin = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: true),
                    Telefono = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Administrador", x => x.Id_Admin);
                });

            migrationBuilder.CreateTable(
                name: "tb_Menu",
                columns: table => new
                {
                    Id_Menu = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Menu", x => x.Id_Menu);
                });

            migrationBuilder.CreateTable(
                name: "tb_Modo_Pago",
                columns: table => new
                {
                    Id_Modo_Pago = table.Column<Guid>(nullable: false),
                    Factura = table.Column<string>(nullable: true),
                    Modo_de_Pago = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Modo_Pago", x => x.Id_Modo_Pago);
                });

            migrationBuilder.CreateTable(
                name: "tb_Bebida",
                columns: table => new
                {
                    Id_Bebida = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Precio = table.Column<int>(nullable: false),
                    Id_Menu = table.Column<Guid>(nullable: false),
                    MenuId_Menu = table.Column<Guid>(nullable: true),
                    Id_Categoria = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Bebida", x => x.Id_Bebida);
                    table.ForeignKey(
                        name: "FK_tb_Bebida_tb_Menu_MenuId_Menu",
                        column: x => x.MenuId_Menu,
                        principalTable: "tb_Menu",
                        principalColumn: "Id_Menu",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_Plato",
                columns: table => new
                {
                    Id_Plato = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Precio = table.Column<string>(nullable: true),
                    Id_Menu = table.Column<Guid>(nullable: false),
                    Id_Categoria = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Plato", x => x.Id_Plato);
                    table.ForeignKey(
                        name: "FK_tb_Plato_tb_Menu_Id_Plato",
                        column: x => x.Id_Plato,
                        principalTable: "tb_Menu",
                        principalColumn: "Id_Menu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Cliente",
                columns: table => new
                {
                    Id_Cliente = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: true),
                    Telefono = table.Column<int>(nullable: false),
                    Id_Menu = table.Column<Guid>(nullable: false),
                    Id_Modo_Pago = table.Column<Guid>(nullable: false),
                    ModoId_Modo_Pago = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Cliente", x => x.Id_Cliente);
                    table.ForeignKey(
                        name: "FK_tb_Cliente_tb_Menu_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "tb_Menu",
                        principalColumn: "Id_Menu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Cliente_tb_Modo_Pago_ModoId_Modo_Pago",
                        column: x => x.ModoId_Modo_Pago,
                        principalTable: "tb_Modo_Pago",
                        principalColumn: "Id_Modo_Pago",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_Descripcion_Bebida",
                columns: table => new
                {
                    Id_Tipo_Bebida = table.Column<Guid>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Id_Bebida = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Descripcion_Bebida", x => x.Id_Tipo_Bebida);
                    table.ForeignKey(
                        name: "FK_tb_Descripcion_Bebida_tb_Bebida_Id_Bebida",
                        column: x => x.Id_Bebida,
                        principalTable: "tb_Bebida",
                        principalColumn: "Id_Bebida",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Categoria",
                columns: table => new
                {
                    Id_Categoria = table.Column<Guid>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    PlatoId_Plato = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Categoria", x => x.Id_Categoria);
                    table.ForeignKey(
                        name: "FK_tb_Categoria_tb_Bebida_Id_Categoria",
                        column: x => x.Id_Categoria,
                        principalTable: "tb_Bebida",
                        principalColumn: "Id_Bebida",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Categoria_tb_Plato_PlatoId_Plato",
                        column: x => x.PlatoId_Plato,
                        principalTable: "tb_Plato",
                        principalColumn: "Id_Plato",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_Descripcion_plato",
                columns: table => new
                {
                    Id_Tipo_Plato = table.Column<Guid>(nullable: false),
                    Descrpcion = table.Column<string>(nullable: true),
                    Id_Plato = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Descripcion_plato", x => x.Id_Tipo_Plato);
                    table.ForeignKey(
                        name: "FK_tb_Descripcion_plato_tb_Plato_Id_Plato",
                        column: x => x.Id_Plato,
                        principalTable: "tb_Plato",
                        principalColumn: "Id_Plato",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Pedido",
                columns: table => new
                {
                    Id_Pedido = table.Column<Guid>(nullable: false),
                    Id_Admin = table.Column<Guid>(nullable: false),
                    Id_Cliente = table.Column<Guid>(nullable: false),
                    AdministradorId_Admin = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Pedido", x => x.Id_Pedido);
                    table.ForeignKey(
                        name: "FK_tb_Pedido_tb_Administrador_AdministradorId_Admin",
                        column: x => x.AdministradorId_Admin,
                        principalTable: "tb_Administrador",
                        principalColumn: "Id_Admin",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_Pedido_tb_Cliente_Id_Pedido",
                        column: x => x.Id_Pedido,
                        principalTable: "tb_Cliente",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Bebida_MenuId_Menu",
                table: "tb_Bebida",
                column: "MenuId_Menu");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Categoria_PlatoId_Plato",
                table: "tb_Categoria",
                column: "PlatoId_Plato");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Cliente_ModoId_Modo_Pago",
                table: "tb_Cliente",
                column: "ModoId_Modo_Pago");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Descripcion_Bebida_Id_Bebida",
                table: "tb_Descripcion_Bebida",
                column: "Id_Bebida");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Descripcion_plato_Id_Plato",
                table: "tb_Descripcion_plato",
                column: "Id_Plato");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pedido_AdministradorId_Admin",
                table: "tb_Pedido",
                column: "AdministradorId_Admin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Categoria");

            migrationBuilder.DropTable(
                name: "tb_Descripcion_Bebida");

            migrationBuilder.DropTable(
                name: "tb_Descripcion_plato");

            migrationBuilder.DropTable(
                name: "tb_Pedido");

            migrationBuilder.DropTable(
                name: "tb_Bebida");

            migrationBuilder.DropTable(
                name: "tb_Plato");

            migrationBuilder.DropTable(
                name: "tb_Administrador");

            migrationBuilder.DropTable(
                name: "tb_Cliente");

            migrationBuilder.DropTable(
                name: "tb_Menu");

            migrationBuilder.DropTable(
                name: "tb_Modo_Pago");
        }
    }
}
