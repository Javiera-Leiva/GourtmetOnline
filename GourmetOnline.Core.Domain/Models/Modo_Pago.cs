using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GourmetOnline.Core.Domain.Models
{
   public  class Modo_Pago
    {
        public Guid Id_Modo_Pago { get; set; }

        public string Factura { get; set; }

        public Boolean Modo_de_Pago { get; set; }

        public Guid Id_Cliente { get; set; }
        [ForeignKey("Id_Modo_Pago")]

        public Cliente Cliente { get; set; }

    }
}
