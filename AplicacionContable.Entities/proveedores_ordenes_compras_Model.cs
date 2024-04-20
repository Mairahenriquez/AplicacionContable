﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionContable.Entities
{
    [Table("proveedores_ordenes_compras")]
    public class proveedores_ordenes_compras_Model
    {
        [Key]
        public int PK_codigo { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
        public DateTime fecha_hora { get; set; }
        public string observaciones { get; set; }
        public decimal subtotal { get; set; }
        public decimal iva { get; set; }
        public decimal descuento { get; set; }
        public decimal total { get; set; }
        public int FK_bodega { get; set; }
        public int FK_proveedor { get; set; }
        public int FK_forma_pago { get; set; }
        public int? FK_partida { get; set; }
        public int FK_estado { get; set; }
        public int FK_usuario { get; set; }
        public int FK_condicion_pago { get; set; }
        public int? FK_movimiento { get; set; }
    }
}
