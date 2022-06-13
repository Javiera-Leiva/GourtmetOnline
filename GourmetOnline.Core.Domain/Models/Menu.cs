using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace GourmetOnline.Core.Domain.Models
{
    public class Menu
    {
        public Guid Id_Menu { get; set; }

        public Guid Id_Cliente { get; set; }
        [ForeignKey("Id_Menu")]

        public Cliente Cliente { get; set; }
        public List<Plato> Plato { get; set; }
        public List<Bebida> Bebida { get; set; }



    }


}
