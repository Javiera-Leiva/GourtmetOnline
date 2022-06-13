using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace GourmetOnline.Core.Domain.Models
{
    public class Plato
    {
        public Guid Id_Plato { get; set; }

        public string Nombre { get; set; }

        public string Precio { get; set; }

        public Guid Id_Menu { get; set; }
        [ForeignKey("Id_Plato")]

        public Guid Id_Categoria { get; set; }
        [ForeignKey("Id_Plato")]

      
        public Menu Menu { get; set; }
      
    
        
        public List<Descripcion_Plato> Descripcion_Platos { get; set; }

        public List<Categoria> Categoria { get; set; }

    }
}
