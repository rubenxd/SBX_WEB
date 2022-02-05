using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBX_WEB.Data
{
    public class ClienteServicio
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion
        #region Constructor
        public ClienteServicio(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion
        #region Get List of Cliente
        public async Task<List<Cliente>> GetAllClienteAsync()
        {
            return await _appDBContext.clientes.ToListAsync();
        }
        public List<Cliente> GetAllCliente()
        {
            return  _appDBContext.clientes.ToList();
        }
        #endregion
        #region Get Cliente by Id
        public async Task<Cliente> GetClienteAsync(int Id)
        {
            Cliente cliente = await _appDBContext.clientes.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return cliente;
        }
        public async Task<Cliente> GetClienteXDNIAsync(string DNI)
        {
            Cliente cliente = await _appDBContext.clientes.FirstOrDefaultAsync(c => c.DNI.Equals(DNI));
            return cliente;
        }
        #endregion
        #region Insert cliente
        public async Task<bool> InsertClienteAsync(Cliente cliente)
        {
            await _appDBContext.clientes.AddAsync(cliente);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public bool InsertCliente(Cliente cliente)
        {
             _appDBContext.clientes.AddAsync(cliente);
             _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        #region Update cliente
        public async Task<bool> UpdateClienteAsync(Cliente cliente)
        {
            _appDBContext.clientes.Update(cliente);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public bool UpdateCliente(Cliente cliente)
        {
            _appDBContext.clientes.Update(cliente);
            _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        #region  delete cliente
        public async Task<bool> EliminarClienteAsync(Cliente cliente)
        {
            _appDBContext.Remove(cliente);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        public async Task<Cliente> GetClienteXNombreAsync(string nombre)
        {
            Cliente cliente = await _appDBContext.clientes.FirstOrDefaultAsync(c => c.Nombre.Equals(nombre));
            return cliente;
        }
    }
}
