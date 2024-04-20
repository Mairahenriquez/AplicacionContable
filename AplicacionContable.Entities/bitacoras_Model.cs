using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionContable.Entities
{
    [Table("bitacoras")]
    public class bitacoras_Model
    {
        [Key]
        public int PK_codigo { get; set; }
        public string descripcion { get; set; }
        public int FK_usuario { get; set; }
    }
}
