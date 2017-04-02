using Entities.Entidades;
using System;
using System.Collections.Generic;
using Util;
using DataAccess.Repositories;

namespace Logic
{
    public class LogicModel
    {
        private ModelRepository _modelRepository;
        public IEnumerable<Modelo> GetAll()
        {
            _modelRepository = new ModelRepository();
            IEnumerable<Modelo> listModels;
            try
            {
                listModels = _modelRepository.GetAll();
            }
            catch(AppException appex)
            {
                throw appex;
            }
            return listModels;
        }

        public void AddNewModel(Modelo model)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
