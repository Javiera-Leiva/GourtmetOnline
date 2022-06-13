using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace GourmetOnline.Core.Domain.Models
{
    public class Cliente
    {
        public Guid Id_Cliente { get; set; }


        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Contraseña { get; set; }

        public int Telefono { get; set; }

        public List<Pedido> Pedidos { get; set; }
        public List<Menu> Menus { get; set; }
        public List<Modo_Pago> Modo_pagos { get; set; }







    }



    }

