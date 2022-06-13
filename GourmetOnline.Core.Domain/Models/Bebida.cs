using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace GourmetOnline.Core.Domain.Models
{
    public class Bebida
    {
        public Guid Id_Bebida { get; set; }

        public string Nombre { get; set; }

        public int Precio { get; set; }

        public Guid Id_Menu { get; set; }
       

       

        public  Menu Menu { get; set; }


        public Guid Id_Categoria { get; set; }
        [ForeignKey("Id_Categoria")]
        public List<Categoria> Categoria { get; set; }
        public List<Descripcion_Bebida> Descripcion_Bebida { get; set; }

    }
}
