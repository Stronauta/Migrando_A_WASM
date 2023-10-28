using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASM_Clientes.Shared
{
    public class Clientes
    {
        [Key]
        public int ClientesId { get; set; }

        [Required(ErrorMessage = "El campo Nombres es obligatorio.")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Solo se permiten letras y espacios.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El campo Telefono es obligatorio.")]
        [RegularExpression(@"^\d{3}\d{3}\d{4}$", ErrorMessage = "El campo Teléfono debe tener el formato XXXXXXXXXX.")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "El campo Celular es obligatorio.")]
        [RegularExpression(@"^\d{3}\d{3}\d{4}$", ErrorMessage = "El campo Celular debe tener el formato XXXXXXXXXX.")]
        public string? Celular { get; set; }

        [Required(ErrorMessage = "El campo Rnc es obligatorio.")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "El campo Rnc debe tener el formato 000000000.")]
        public string? Rnc { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        public string? Gmail { get; set; }

        [Required(ErrorMessage = "El campo Direccion es obligatorio.")]
        [StringLength(90, ErrorMessage = "El campo Dirección no debe de tener más de 90 caracteres.")]
        public string? Direccion { get; set; }
    }
}
