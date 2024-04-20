using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionContable.Entities
{
    [Table("vw_inventarios_movimientos")]
    public class vw_inventarios_movimientos_Model
    {
        [Key]
        public int PK_codigo { get; set; }
        public DateTime fecha { get; set; }
        public DateTime fecha_hora { get; set; }
        public string referencia { get; set; }
        public string observaciones { get; set; }
        public decimal costo_unitario { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal costo_total { get; set; }
        public decimal precio_total { get; set; }
        public int FK_tipo_movimiento { get; set; }
        public int FK_estado { get; set; }
        public int FK_bodega { get; set; }
        public int FK_usuario { get; set; }
        public string estado { get; set; }
        public string estado_color { get; set; }
        public string bodega { get; set; }
        public int? FK_compra { get; set; }
        public int? FK_factura { get; set; }
    }
}
