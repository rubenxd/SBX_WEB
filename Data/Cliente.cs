using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SBX_WEB.Data
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="Maximo 50 caracteres")]
        public string DNI { get; set; }
        [Required]
        [StringLength(200, ErrorMessage = "Maximo 200 caracteres")]
        public string Nombre { get; set; }
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string Ciudad { get; set; }
        [StringLength(200, ErrorMessage = "Maximo 200 caracteres")]
        public string Direccion { get; set; }
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string telefono { get; set; }
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Celular { get; set; }
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string Email { get; set; }
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string SitioWeb { get; set; }
    }
}
