using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SBX_WEB.Data
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string DescripcionRol { get; set; }
    }
}
