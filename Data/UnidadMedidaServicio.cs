using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBX_WEB.Data
{
    public class UnidadMedidaServicio
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion
        #region Constructor
        public UnidadMedidaServicio(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion
        #region Get List of UnidadMedida
        public async Task<List<UnidadMedida>> GetAllUnidadMedidaAsync()
        {
            return await _appDBContext.unidadMedidas.ToListAsync();
        }
        public async Task<IEnumerable<UnidadMedida>> GetAllIEnumerableUnidadMedidaAsync()
        {
            return await _appDBContext.unidadMedidas.ToListAsync();
        }
        public List<UnidadMedida> GetAllUnidadMedida()
        {
            return _appDBContext.unidadMedidas.ToList();
        }
        public IEnumerable<UnidadMedida> GetAllIEnumerableUnidadMedida()
        {
            return _appDBContext.unidadMedidas.AsQueryable();
        }
        #endregion
        #region Get UnidadMedida by Id
        public async Task<UnidadMedida> GetUnidadMedidaAsync(int Id)
        {
            UnidadMedida Unidadmedida = await _appDBContext.unidadMedidas.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return Unidadmedida;
        }
        public async Task<UnidadMedida> GetUnidadMedidaXNombreAsync(string Nombre)
        {
            UnidadMedida unidadMedida = await _appDBContext.unidadMedidas.FirstOrDefaultAsync(c => c.Nombre.Equals(Nombre));
            return unidadMedida;
        }
        #endregion
        #region Insert UnidadMedida
        public async Task<bool> InsertUnidadMedidaAsync(UnidadMedida unidadMedida)
        {
            await _appDBContext.unidadMedidas.AddAsync(unidadMedida);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public bool InsertUnidadMedida(UnidadMedida unidadMedida)
        {
            _appDBContext.unidadMedidas.AddAsync(unidadMedida);
            _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        #region Update unidadMedida
        public async Task<bool> UpdateUnidadMedidaAsync(UnidadMedida unidadMedida)
        {
            _appDBContext.unidadMedidas.Update(unidadMedida);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public bool UpdateUnidadMedida(UnidadMedida Unidadmedida)
        {
            _appDBContext.unidadMedidas.Update(Unidadmedida);
            _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        #region  delete UnidadMedida
        public async Task<bool> EliminarProductoAsync(UnidadMedida Unidadmedida)
        {
            _appDBContext.Remove(Unidadmedida);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
