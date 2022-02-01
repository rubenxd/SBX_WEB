using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBX_WEB.Data
{
    public class ProveedorServicio
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion
        #region Constructor
        public ProveedorServicio(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion
        #region Get List of Proveedor
        public async Task<List<Proveedor>> GetAllProveedorAsync()
        {
            return await _appDBContext.proveedores.ToListAsync();
        }
        public List<Proveedor> GetAllProveedor()
        {
            return _appDBContext.proveedores.ToList();
        }
        #endregion
        #region Get Proveedor by Id
        public async Task<Proveedor> GetProveedorAsync(int Id)
        {
            Proveedor proveedor = await _appDBContext.proveedores.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return proveedor;
        }
        public async Task<Proveedor> GetProveedorXDNIAsync(string DNI)
        {
            Proveedor proveedor = await _appDBContext.proveedores.FirstOrDefaultAsync(c => c.DNI.Equals(DNI));
            return proveedor;
        }
        public async Task<Proveedor> GetProveedorXNombreAsync(string Nombre)
        {
            Proveedor proveedor = await _appDBContext.proveedores.FirstOrDefaultAsync(c => c.Nombre.Equals(Nombre));
            return proveedor;
        }
        #endregion
        #region Insert Proveedor
        public async Task<bool> InsertProveedorAsync(Proveedor proveedor)
        {
            await _appDBContext.proveedores.AddAsync(proveedor);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public bool InsertProveedor(Proveedor proveedor)
        {
            _appDBContext.proveedores.AddAsync(proveedor);
            _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        #region Update Proveedor
        public async Task<bool> UpdateProveedorAsync(Proveedor proveedor)
        {
            _appDBContext.proveedores.Update(proveedor);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public bool UpdateProveedor(Proveedor proveedor)
        {
            _appDBContext.proveedores.Update(proveedor);
            _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        #region  delete Proveedor
        public async Task<bool> EliminarProveedorAsync(Proveedor proveedor)
        {
            _appDBContext.Remove(proveedor);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
