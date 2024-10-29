using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.Models
{

    class product
    {
        public static List<product> ProductList = new List<product>();
       
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaCreacion { get; set; }

        public product(string nombre, decimal precio, DateTime fechaCreacion)
        {
         
            Nombre = nombre;
            Precio = precio;
            FechaCreacion = fechaCreacion;
        }
    }
}
