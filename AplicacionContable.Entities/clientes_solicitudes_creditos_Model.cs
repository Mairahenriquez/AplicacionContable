using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionContable.Entities
{
    [Table("clientes_solicitudes_creditos")]
    public class clientes_solicitudes_creditos_Model
    {
        [Key]
        public int PK_codigo { get; set; }
        public string observaciones { get; set; }
        public DateTime fecha { get; set; }
        public DateTime fecha_hora { get; set; }
        public decimal monto { get; set; }
        public int FK_usuario { get; set; }
        public int FK_cliente { get; set; }
        public int FK_estado { get; set; }
        public int FK_condicion_pago { get; set; }
    }
}
