using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace GourmetOnline.Core.Domain.Models
{
   public  class Pedido
    {
        public Guid Id_Pedido { get; set; }

        public Guid Id_Admin { get; set; }
        [ForeignKey("Id_Pedido")]
        public Guid Id_Cliente { get; set; }
        [ForeignKey("Id_Pedido")]
        public Cliente Cliente { get; set; }
        public Administrador Administrador { get; set; }

      
       
    }
}
