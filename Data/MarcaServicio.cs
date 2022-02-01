using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBX_WEB.Data
{
    public class MarcaServicio
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion
        #region Constructor
        public MarcaServicio(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion
        #region Get List of Marca
        public async Task<List<Marca>> GetAllMarcaAsync()
        {
            return await _appDBContext.marcas.ToListAsync();
        }
        public async Task<IEnumerable<Marca>> GetAllIEnumerableMarcaAsync()
        {
            return await _appDBContext.marcas.ToListAsync();
        }
        public List<Marca> GetAllMarca()
        {
            return _appDBContext.marcas.ToList();
        }
        public IEnumerable<Marca> GetAllIEnumerableMarca()
        {
            return _appDBContext.marcas.AsQueryable();
        }
        #endregion
        #region Get Marca by Id
        public async Task<Marca> GetMarcaAsync(int Id)
        {
            Marca marca = await _appDBContext.marcas.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return marca;
        }
        public async Task<Marca> GetMarcaXNombreAsync(string Nombre)
        {
            Marca marca = await _appDBContext.marcas.FirstOrDefaultAsync(c => c.Nombre.Equals(Nombre));
            return marca;
        }
        #endregion
        #region Insert Marca
        public async Task<bool> InsertMarcaAsync(Marca marca)
        {
            await _appDBContext.marcas.AddAsync(marca);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public bool InsertMarca(Marca marca)
        {
            _appDBContext.marcas.AddAsync(marca);
            _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        #region Update Marca
        public async Task<bool> UpdatecategoriaAsync(Marca marca)
        {
            _appDBContext.marcas.Update(marca);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public bool UpdateMarca(Marca marca)
        {
            _appDBContext.marcas.Update(marca);
            _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        #region  delete Marca
        public async Task<bool> EliminarMarcaAsync(Marca marca)
        {
            _appDBContext.Remove(marca);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
