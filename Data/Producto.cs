using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SBX_WEB.Data
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Referencia { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float IVA { get; set; }
        public int IdunidadMedida { get; set; }
        public UnidadMedida unidadMedida { get; set; }
        public float Medida { get; set; }
        public int Idestado { get; set; }
        public Estado estado { get; set; }
        public int IdCategoria { get; set; }
        public Categoria categoria { get; set; }
        public int Idmarca { get; set; }
        public Marca marca { get; set; }
        public int Idproveedor { get; set; }
        public Proveedor proveedor { get; set; }
        public string ModoVenta { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }
        public float Cantidad { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Costo { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioVenta { get; set; }
        public string CodigoBarras { get; set; }
        public float SubCantidad { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorSubcantidad { get; set; }
        public int Sobres { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorSobre { get; set; }
        public int Idusuario { get; set; }
        public Usuario usuario { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Movimiento { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Nota { get; set; }
    }
}
