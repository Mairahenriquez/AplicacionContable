using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionContable.Entities
{
    [Table("contabilidad_cuentas_contables_clasificaciones")]
    public class contabilidad_cuentas_contables_clasificaciones_Model
    {
        [Key]
        public int PK_codigo { get; set; }
        public string identificador { get; set; }
        public string nombre { get; set; }
    }
}
