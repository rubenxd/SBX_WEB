using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SBX_WEB.Data
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreDocumento { get; set; }
        public int ConsecutivoDocumento { get; set; }
        public int ProductoId { get; set; }
        public Producto producto { get; set; }
        public string ModoVenta { get; set; }
        public string UM { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Cantidad { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Costo { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioVenta { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Descuento { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Efectivo { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Cambio { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }
        public int ClienteId { get; set; }
        public Cliente cliente { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal IVA { get; set; }
        public int UsuarioId { get; set; }
        public string Nota { get; set; }
        public string Movimiento { get; set; }
    }
}
