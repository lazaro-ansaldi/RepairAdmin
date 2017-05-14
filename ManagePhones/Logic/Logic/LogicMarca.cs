using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using ManagePhones.DataAccess.Repositories;
using ManagePhones.Util.Exceptions;
using ManagePhones.Entities.Entidades;

namespace ManagePhones.Logic.Logic
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
                throw new LoggedException("Error al intentar consultar la tabla de marcas.", Util.Enums.ExType.Error, sqlex);
            }
            catch(Exception ex)
            {
                throw new LoggedException("Se produjo un error inesperado al intentar obtener las marcas.", Util.Enums.ExType.Fatal, ex);
            }
            finally
            {
                _repository = null;
            }
        }
    }
}
