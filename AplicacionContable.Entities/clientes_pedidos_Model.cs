﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionContable.Entities
{
    [Table("clientes_pedidos")]
    public class clientes_pedidos_Model
    {
        [Key]
        public int PK_codigo { get; set; }
        public DateTime fecha { get; set; }
        public decimal subtotal { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
        public string observaciones { get; set; }
        public string referencia { get; set; }
        public string comentarios { get; set; }
        public int FK_usuario { get; set; }
        public int FK_condicion_pago { get; set; }
        public int FK_estado { get; set; }
        public int FK_cliente { get; set; }
        public int FK_forma_pago { get; set; }
    }
}
