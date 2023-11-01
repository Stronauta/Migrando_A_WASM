using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASM_PizzaPlace.Shared
{
    public class CestaDCompras
    {
        public Clientes clientes { get; set; } = new Clientes();
        public List<int> Pedidos { get; set; } = new List<int>();
        public bool Pago { get; set; }
        public void Add(int PizzaId) => Pedidos.Add(PizzaId);
        public void RemoveAt(int PedidaId) => Pedidos.RemoveAt(PedidaId);
    }
}
