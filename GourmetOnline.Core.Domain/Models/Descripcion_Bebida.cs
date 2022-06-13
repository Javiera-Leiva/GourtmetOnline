using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace GourmetOnline.Core.Domain.Models
{
    public class Descripcion_Bebida
    {
       public Guid Id_Tipo_Bebida { get; set; }

        public string Descripcion { get; set; }

        public Guid Id_Bebida { get; set; }
        [ForeignKey("Id_Bebida")]

        public Bebida Bebida { get; set; }

    }
}
