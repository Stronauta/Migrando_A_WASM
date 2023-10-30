using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WASM_Prioridad.Shared;

namespace WASM_Prioridad.Shared
{
    public class Prioridad
    {
        [Key]
        public int PrioridadId { get; set; }
        [Required(ErrorMessage = "La descripción es requerida")]
        [StringLength(50, ErrorMessage = "La descripción no puede tener más de 50 caracteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Los días de compromiso son requeridos")]
        [Range(1, 30, ErrorMessage = "Los días de compromiso deben estar entre 1 y 30")]
        public string DiasCompromiso { get; set; }
    }
}
