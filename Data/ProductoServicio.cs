using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBX_WEB.Data
{
    public class ProductoServicio
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion
        #region Constructor
        public ProductoServicio(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion
        #region Get List of producto
        public async Task<List<Producto>> GetAllProductoAsync()
        {
            return await _appDBContext.productos.ToListAsync();
        }
        public List<Producto> GetAllProducto()
        {
            return _appDBContext.productos.ToList();
        }
        #endregion
        #region Get Producto by Id
        public async Task<Producto> GetProductoAsync(int Id)
        {
            Producto producto = await _appDBContext.productos.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return producto;
        }
        public async Task<Producto> GetProductoXreferenciaAsync(string referencia)
        {
            Producto producto = await _appDBContext.productos.FirstOrDefaultAsync(c => c.Referencia.Equals(referencia));
            return producto;
        }
        public async Task<Producto> GetProductoXCodigoBarrasAsync(string codigoBarras)
        {
            Producto producto = await _appDBContext.productos.FirstOrDefaultAsync(c => c.CodigoBarras.Equals(codigoBarras));
            return producto;
        }
        #endregion
        #region Insert Producto
        public async Task<bool> InsertProductoAsync(Producto producto)
        {
            await _appDBContext.productos.AddAsync(producto);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public bool InsertCliente(Producto producto)
        {
            _appDBContext.productos.AddAsync(producto);
            _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        #region Update Producto
        public async Task<bool> UpdateProductoAsync(Producto producto)
        {
            _appDBContext.productos.Update(producto);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public bool UpdateProducto(Producto producto)
        {
            _appDBContext.productos.Update(producto);
            _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        #region  delete Producto
        public async Task<bool> EliminarProductoAsync(Producto producto)
        {
            _appDBContext.Remove(producto);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        public async Task<Producto> GetProductoReferenciaAsync(string referencia)
        {
            Producto Productos = await _appDBContext.productos.FirstOrDefaultAsync(c => c.Referencia.Equals(referencia));
            return Productos;
        }
    }
}
