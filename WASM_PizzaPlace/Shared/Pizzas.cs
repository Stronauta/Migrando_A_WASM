using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASM_PizzaPlace.Shared
{
    public class Pizzas
    {
        public int Id { get; }
        public string Nombre { get; }
        public string Despricion { get; }
        public decimal Precio { get; }
        public Picantes Picante { get; }
        public Pizzas(int Id, string Nombre, string Descricpion, decimal Precio, Picantes Picantes)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Despricion = Descricpion;
            this.Precio = Precio;
            this.Picante = Picantes;
        }
    }
}
