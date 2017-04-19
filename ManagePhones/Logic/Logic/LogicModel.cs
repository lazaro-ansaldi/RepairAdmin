using Entities.Entidades;
using System;
using System.Collections.Generic;
using DataAccess.Repositories;
using System.Data.SqlClient;
using Util.Exceptions;

namespace Logic.Logic
{
    public class LogicModel
    {
        private ModelRepository _modelRepository;

        public IEnumerable<Modelo> GetAll()
        {
            _modelRepository = new ModelRepository();
            try
            {
                return _modelRepository.GetAll();
            }
            catch(SqlException sqlex)
            {
                throw new LoggedException("Error al consultar la tabla de modelos.", "Error", sqlex);
            }
            catch(Exception ex)
            {
                throw new LoggedException("Se produjo un error inesperado al intentar obtener los modelos.", "Fatal", ex);
            }
        }

        public void AddNewModel(Modelo model)
        {
            _modelRepository = new ModelRepository();
            try
            {
                _modelRepository.Insert(model);
            }
            catch (SqlException sqlex)
            {
                throw new LoggedException("Error al actualizar la tabla modelos.", "Error", sqlex);
            }
            catch (Exception ex)
            {
                throw new LoggedException("Se produjo un error inesperado al intentar añadir el modelo.", "Fatal", ex);
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

        public void UpdateModel(Modelo model)
        {
            _modelRepository = new ModelRepository();
            try
            {
                _modelRepository.Update(model);
            }
            catch (SqlException sqlex)
            {
                throw new LoggedException("Error al actualizar la tabla modelos.", "Error", sqlex);
            }
            catch (Exception ex)
            {
                throw new LoggedException("Se produjo un error inesperado al intentar actualizar el modelo.", "Fatal", ex);
            }
        }
    }
}
