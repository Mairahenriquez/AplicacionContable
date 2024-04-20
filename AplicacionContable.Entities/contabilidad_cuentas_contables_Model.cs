﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionContable.Entities
{
    [Table("contabilidad_cuentas_contables")]
    public class contabilidad_cuentas_contables_Model
    {
        [Key]
        public int PK_codigo { get; set; }
        public string numero { get; set; }
        public string nombre { get; set; }
        public Boolean cuenta_mayor { get; set; }
        public int? FK_cuenta_contable { get; set; }
        public int FK_clasificasion { get; set; }
    }
}
