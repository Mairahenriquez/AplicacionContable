using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionContable.Entities
{
    [Table("usuarios")]
    public class usuarios_Model
    {
        [Key]
        public int PK_codigo { get; set; }
        public string usuario { get; set; }
        public string nombre { get; set; }
        public string clave { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public int FK_estado { get; set; }
        public int FK_usuario { get; set; }
        public int FK_rol { get; set; }
    }
}
