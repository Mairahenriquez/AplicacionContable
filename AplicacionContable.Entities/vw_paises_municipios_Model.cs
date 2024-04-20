using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionContable.Entities
{
    [Table("vw_paises_municipios")]
    public class vw_paises_municipios_Model
    {        
        public vw_paises_municipios_Model()
        {

        }

        [Key]
        public int PK_codigo { get; set; }
        public string nombre { get; set; }
        public int FK_departamento { get; set; }
        public string departamento { get; set; }
    }
}
