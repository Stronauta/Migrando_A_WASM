using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASM_PizzaPlace.Shared
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Proporcione su direccion de Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Proporcione su nombre")]
        public string Nombre { get; set; } = default!;
        [Required(ErrorMessage = "Ingrese una calle con el numero de la casa")]
        public string Calle { get; set; } = default!;
        [Required(ErrorMessage = "Ingrese una ciudad")]
        public string Ciudad { get; set; } = default!;
    }
}
