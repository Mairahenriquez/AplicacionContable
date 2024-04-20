using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionContable.Entities
{
    [Table("vw_proveedores")]
    public class vw_proveedores_Model
    {
        [Key]
        public int PK_codigo { get; set; }
        public string razon_social { get; set; }
        public string nombre_comercial { get; set; }
        public string dui { get; set; }
        public string nit { get; set; }
        public string nrc { get; set; }
        public string giro { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public DateTime fecha_hora { get; set; }
        public decimal saldo { get; set; }
        public decimal abonado { get; set; }
        public decimal total { get; set; }
        public int FK_municipio { get; set; }
        public int FK_tipo_contribuyente { get; set; }
        public int FK_cuenta_contable { get; set; }
        public string municipio { get; set; }
        public string departamento { get; set; }
    }
}
