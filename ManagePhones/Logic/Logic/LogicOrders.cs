using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Entidades;
using System.Data.SqlClient;
using Util.Exceptions;

namespace Logic.Logic
{
    public class LogicOrders
    {
        private OrderRepository _orderRepository;

        public async Task<IEnumerable<RepairOrder>> GetAll()
        {
            _orderRepository = new OrderRepository();
            try
            {
                return await _orderRepository.GetAll();
            }
            catch(SqlException sqlex)
            {
                throw new LoggedException();
            }
            catch(Exception ex)
            {
                throw new Exception();
            }
            finally
            {
                _orderRepository = null;
            }
        }
    }
}
