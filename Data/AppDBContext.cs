using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBX_WEB.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Proveedor> proveedores { get; set; }
        public DbSet<Marca> marcas { get; set; }
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Estado> estados { get; set; }
        public DbSet<UnidadMedida> unidadMedidas { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Kardex> kardexs { get; set; }
        public DbSet<Venta> ventas { get; set; }
    }
}
