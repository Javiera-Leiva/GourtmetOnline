using System;
using System.Collections.Generic;
using System.Text;

namespace GourmetOnline.Core.Domain.Models
{
    public class Administrador
    {
        public Guid Id_Admin { get; set; }

        public string Nombre_Admin { get; set; }

        public string Correo_Admin { get; set; }

        public string Contraseña { get; set; }

        public int Telefono { get; set; }

        public List<Pedido> Pedidos { get; set; }
    }
}
