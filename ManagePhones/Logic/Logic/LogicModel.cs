using System;
using System.Collections.Generic;
using ManagePhones.DataAccess.Repositories;
using System.Data.SqlClient;
using System.Threading.Tasks;
using ManagePhones.Util.Exceptions;
using ManagePhones.Entities.Entidades;

namespace ManagePhones.Logic.Logic
{
    public class LogicModel
    {
        private ModelRepository _modelRepository;

        public async Task<IEnumerable<Modelo>> GetAll()
        {
            _modelRepository = new ModelRepository();
            try
            {
                return await _modelRepository.GetAll();
            }
            catch(SqlException sqlex)
            {
                throw new LoggedException("Error al consultar la tabla de modelos.", Util.Enums.ExType.Error, sqlex);
            }
            catch(Exception ex)
            {
                throw new LoggedException("Se produjo un error inesperado al intentar obtener los modelos.", Util.Enums.ExType.Fatal, ex);
            }
        }

        public async Task AddNewModel(Modelo model)
        {
            _modelRepository = new ModelRepository();
            try
            {
                await _modelRepository.Insert(model);
            }
            catch (SqlException sqlex)
            {
                throw new LoggedException("Error al actualizar la tabla modelos.", Util.Enums.ExType.Error, sqlex);
            }
            catch (Exception ex)
            {
                throw new LoggedException("Se produjo un error inesperado al intentar añadir el modelo.", Util.Enums.ExType.Fatal, ex);
            }
        }

        public void DeleteModel(Modelo model)
        {
            throw new NotImplementedException();
        }

        public Modelo GetOneById(Modelo model)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateModel(Modelo model)
        {
            _modelRepository = new ModelRepository();
            try
            {
                await _modelRepository.Update(model);
            }
            catch (SqlException sqlex)
            {
                throw new LoggedException("Error al actualizar la tabla modelos.", Util.Enums.ExType.Error, sqlex);
            }
            catch (Exception ex)
            {
                throw new LoggedException("Se produjo un error inesperado al intentar actualizar el modelo.", Util.Enums.ExType.Fatal, ex);
            }
        }
    }
}
