using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.Models
{
    internal class product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaCreacion { get; set; }

        public product(int id, string nombre, decimal precio, DateTime fechaCreacion)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            FechaCreacion = fechaCreacion;
        }
    }
}
