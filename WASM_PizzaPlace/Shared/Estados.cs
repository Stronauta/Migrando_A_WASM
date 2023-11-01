using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASM_PizzaPlace.Shared
{
    public class Estados
    {
        public MenuLocal Menu { get; set; } = new MenuLocal();
        public CestaDCompras cestaDCompras { get; } = new CestaDCompras();
        public InterfazUsuario Interfaz { get; set; } = new InterfazUsuario();
        public decimal PrecioTotal => cestaDCompras.Pedidos.Sum(Id => Menu.ObtenerPizzas(Id)!.Precio);


    }
}
