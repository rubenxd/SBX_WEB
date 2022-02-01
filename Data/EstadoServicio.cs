using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBX_WEB.Data
{
    public class EstadoServicio
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion
        #region Constructor
        public EstadoServicio(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion
        #region Get List of Estado
        public async Task<List<Estado>> GetAllEstadoAsync()
        {
            return await _appDBContext.estados.ToListAsync();
        }
        public async Task<IEnumerable<Estado>> GetAllIEnumerableEstadoAsync()
        {
            return await _appDBContext.estados.ToListAsync();
        }
        public List<Estado> GetAllEstado()
        {
            return _appDBContext.estados.ToList();
        }
        public IEnumerable<Estado> GetAllIEnumerableEstado()
        {
            return _appDBContext.estados.AsQueryable();
        }
        #endregion
        #region Get Estado by Id
        public async Task<Estado> GetEstadoAsync(int Id)
        {
            Estado estado = await _appDBContext.estados.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return estado;
        }
        public async Task<Estado> GetEstadoXNombreAsync(string Nombre)
        {
            Estado estado = await _appDBContext.estados.FirstOrDefaultAsync(c => c.Nombre.Equals(Nombre));
            return estado;
        }
        #endregion
        #region Insert Estado
        public async Task<bool> InsertEstadoAsync(Estado estado)
        {
            await _appDBContext.estados.AddAsync(estado);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public bool InsertEstado(Estado estado)
        {
            _appDBContext.estados.AddAsync(estado);
            _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        #region Update Estado
        public async Task<bool> UpdateEstadoAsync(Estado estado)
        {
            _appDBContext.estados.Update(estado);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public bool UpdateEstado(Estado estado)
        {
            _appDBContext.estados.Update(estado);
            _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        #region  delete Estado
        public async Task<bool> EliminarestadoAsync(Estado estado)
        {
            _appDBContext.Remove(estado);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
