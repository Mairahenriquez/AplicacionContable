using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionContable.Entities
{
    [Table("inventarios")]
    public class inventarios_Model
    {
        [Key]
        public int PK_codigo { get; set; }
        public string identificador { get; set; }
        public string descripcion { get; set; }
        public string observaciones { get; set; }
        public string imagen { get; set; }
        public DateTime? fecha_vencimiento { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal costo_unitario { get; set; }
        public decimal precio_cif { get; set; }
        public decimal precio_fob { get; set; }
        public Boolean comprable { get; set; }
        public Boolean vendible { get; set; }
        public decimal precio_total { get; set; }
        public decimal costo_total { get; set; }
        public decimal descuento { get; set; }
        public decimal existencia_fisica { get; set; }
        public int FK_estado { get; set; }
        public int? FK_anio { get; set; }
        public int FK_estado_fisico { get; set; }
        public int FK_cuenta_contable_inventarios { get; set; }
        public int FK_cuenta_contable_costo_venta { get; set; }
        public int FK_cuenta_contable_ingreso_venta { get; set; }
        public int FK_cuenta_contable_devoluciones { get; set; }
        public decimal porcentaje_ganacia { get; set; }
    }
}
