using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASM_Tickets.Shared
{
    public class Tickets
    {
        [Key]
        public int TicketsId { get; set; }
        public int ClientesId { get; set; }
        public int SistemaId { get; set; }
        public int PrioridadId { get; set; }
        [Required(ErrorMessage ="La fecha es obligatoria")]
        public DateTime Fecha { get; set; } = DateTime.Now;
        [Required(ErrorMessage ="El solicitante es obligatorio")]
        public string? SolicitadoPor { get; set; }
        [Required(ErrorMessage ="El asunto es obligatorio")]
        public string? Asunto { get; set; }
        [Required(ErrorMessage ="La descripcion es obligatoria")]
        public string? Descripcion { get; set; }

    }
}