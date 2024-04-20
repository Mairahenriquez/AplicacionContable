using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionContable.Entities
{
    [Table("vw_proveedores_compras_detalle")]
    public class vw_proveedores_compras_detalle_Model
    {
        [Key]
        public int PK_codigo { get; set; }
        public string descripcion { get; set; }
        public decimal cantidad { get; set; }
        public decimal costo_unitario { get; set; }
        public decimal subtotal { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
        public int FK_compra { get; set; }
        public int FK_inventario { get; set; }
        public int FK_bodega { get; set; }
        public string inventario_identificador { get; set; }
    }
}
