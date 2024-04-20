using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionContable.Entities
{
    [Table("bodegas")]
    public class bodegas_Model
    {
        [Key]
        public int PK_codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string observaciones { get; set; }
        public decimal cantidad_total { get; set; }
        public decimal costo_total { get; set; }
        public decimal precio_total { get; set; }
        public int FK_usuario { get; set; }
    }
}
