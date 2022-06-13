using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace GourmetOnline.Core.Domain.Models
{
    public class Categoria
    {
        public Guid Id_Categoria { get; set; }

        public string Descripcion { get; set; }

    }
}
