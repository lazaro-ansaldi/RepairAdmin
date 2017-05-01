using DataAccess.Repositories;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Util.Exceptions;

namespace Logic.Logic
{
    public class LogicClient
    {
        private ClientRepository _clientRepository;

        public async Task InsertNewCliente(Cliente cliente)
        {
            _clientRepository = new ClientRepository();
            try
            {
                await _clientRepository.Insert(cliente);
            }
            catch(SqlException sqlex)
            {
                throw new LoggedException("Error al actualizar la tabla de clientes.", "Error", sqlex);
            }
            catch(Exception ex)
            {
                throw new LoggedException("Se produjo un error al intentar insertar el nuevo cliente.", "Fatal", ex);
            }
        }

        public async Task UpdateCliente(Cliente cliente)
        {
            _clientRepository = new ClientRepository();
            try
            {
                await _clientRepository.Update(cliente);
            }
            catch (SqlException sqlex)
            {
                throw new LoggedException("Error al actualizar la tabla de clientes.", "Error", sqlex);
            }
            catch (Exception ex)
            {
                throw new LoggedException("Se produjo un error al intentar modificar el cliente.", "Fatal", ex);
            }
        }

        public async Task<IEnumerable<Cliente>> GetAll()
        {
            _clientRepository = new ClientRepository();
            try
            {
                return await _clientRepository.GetAll();
            }
            catch (SqlException sqlex)
            {
                throw new LoggedException("Error al consultar la tabla de clientes.", "Error", sqlex);
            }
            catch (Exception ex)
            {
                throw new LoggedException("Se produjo un error al intentar obtener los clientes.", "Fatal", ex);
            }
        }
    }
}
