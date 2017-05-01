using System.Collections.Generic;
using DataAccess.Repositories;
using Entities.Entidades;
using Util.Exceptions;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class LogicMarca
    {
        private MarcaRepository _repository;

        public async Task<IEnumerable<Marca>> GetMarcas()
        {
            _repository = new MarcaRepository();
            try
            {
                return await _repository.GetAll();
            }
            catch(SqlException sqlex)
            {
                throw new LoggedException("Error al intentar consultar la tabla de marcas.", "Error", sqlex);
            }
            catch(Exception ex)
            {
                throw new LoggedException("Se produjo un error inesperado al intentar obtener las marcas.", "Fatal", ex);
            }
            finally
            {
                _repository = null;
            }
        }
    }
}
