using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASM_PizzaPlace.Shared
{
    public class MenuLocal
    {
        public List<Pizzas> Pizzas { get; set; } = new List<Pizzas>();
        public void Add(Pizzas pizzas) => Pizzas.Add(pizzas);
        public Pizzas? ObtenerPizzas(int id) => Pizzas.SingleOrDefault(p => p.Id == id);
    }
}
