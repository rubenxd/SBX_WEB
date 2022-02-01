using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBX_WEB.Data
{
    public class CategoriaServicio
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion
        #region Constructor
        public CategoriaServicio(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion
        #region Get List of Categoria
        public async Task<List<Categoria>> GetAllCategoriaAsync()
        {
            return await _appDBContext.categorias.ToListAsync();
        }
        public async Task<IEnumerable<Categoria>> GetAllIEnumerableCategoriaAsync()
        {
            return await _appDBContext.categorias.ToListAsync();
        }
        public List<Categoria> GetAllCategoria()
        {
            return _appDBContext.categorias.ToList();
        }
        public IEnumerable<Categoria> GetAllIEnumerableCategoria()
        {
            return _appDBContext.categorias.AsQueryable();
        }
        #endregion
        #region Get Categoria by Id
        public async Task<Categoria> GetCategoriaAsync(int Id)
        {
            Categoria categoria = await _appDBContext.categorias.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return categoria;
        }
        public async Task<Categoria> GetcategoriaXnombreAsync(string Nombre)
        {
            Categoria categoria = await _appDBContext.categorias.FirstOrDefaultAsync(c => c.Nombre.Equals(Nombre));
            return categoria;
        }
        #endregion
        #region Insert Categoria
        public async Task<bool> InsertcategoriaAsync(Categoria categoria)
        {
            await _appDBContext.categorias.AddAsync(categoria);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public bool Insertcategoria(Categoria categoria)
        {
            _appDBContext.categorias.AddAsync(categoria);
            _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        #region Update categoria
        public async Task<bool> UpdatecategoriaAsync(Categoria categoria)
        {
            _appDBContext.categorias.Update(categoria);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public bool Updatecategoria(Categoria categoria)
        {
            _appDBContext.categorias.Update(categoria);
            _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        #region  delete categoria
        public async Task<bool> EliminarcategoriaAsync(Categoria categoria)
        {
            _appDBContext.Remove(categoria);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
