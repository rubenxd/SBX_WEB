using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBX_WEB.Data
{
    public class VentaServicio
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion
        #region Constructor
        public VentaServicio(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion
        #region Get List of Venta
        public async Task<List<Venta>> GetAllVentaAsync()
        {
            return await _appDBContext.ventas.ToListAsync();
        }
        #endregion
        public async Task<Venta> GetVentaAsync(int Id)
        {
            Venta venta = await _appDBContext.ventas.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return venta;
        }
        #region Get Venta by Id
        public Venta GetVenta(int Id)
        {
            Venta venta = _appDBContext.ventas.FirstOrDefault(c => c.Id.Equals(Id));
            return venta;
        }
        #endregion
        #region Get Venta by referencia
        //public Venta GetVentaReferencia(string referencia)
        //{
        //    Venta venta = _appDBContext.ventas.FirstOrDefault(c => c.Referencia.Equals(referencia));
        //    return venta;
        //}
        //public async Task<ProductosVen> GetProductosVenReferenciaAsync(string referencia)
        //{
        //    ProductosVen Productosven = await _appDBContext.productosvens.FirstOrDefaultAsync(c => c.Referencia.Equals(referencia));
        //    return Productosven;
        //}
        #endregion

        #region Insert producto
        public async Task<bool> InsertVentaAsync(Venta venta)
        {
            await _appDBContext.ventas.AddAsync(venta);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public bool InsertVenta(Venta venta)
        {
            _appDBContext.ventas.Add(venta);
            _appDBContext.SaveChanges();
            return true;
        }
        #endregion
        #region  delete Producto
        public async Task<bool> EliminarVentaAsync(Venta venta)
        {
            _appDBContext.Remove(venta);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

    }
}
