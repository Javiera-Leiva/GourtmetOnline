using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace GourmetOnline.Core.Domain.Models
{
    public class Descripcion_Plato
    {
        public Guid Id_Tipo_Plato { get; set; }

        public string Descrpcion { get; set; }

        public Guid Id_Plato { get; set; }
        [ForeignKey("Id_Plato")]

        public Plato Plato { get; set; }

    }
}
