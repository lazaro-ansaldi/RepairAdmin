using DataAccess.Repositories;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Util.Exceptions;

namespace Logic.Logic
{
    public class LogicClient
    {
        private ClientRepository _clientRepository;

        public void InsertNewCliente(Cliente cliente)
        {
            _clientRepository = new ClientRepository();
            try
            {
                _clientRepository.Insert(cliente);
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

        public void UpdateCliente(Cliente cliente)
        {
            _clientRepository = new ClientRepository();
            try
            {
                _clientRepository.Update(cliente);
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

        public IEnumerable<Cliente> GetAll()
        {
            _clientRepository = new ClientRepository();
            try
            {
                return _clientRepository.GetAll();
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
