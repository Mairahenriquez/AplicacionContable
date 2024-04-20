using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionContable.Entities
{
    [Table("usuarios_roles")]
    public class usuarios_roles_Model
    {

        [Key]
        public int PK_codigo { get; set; }
        public string nombre { get; set; }
    }
}
