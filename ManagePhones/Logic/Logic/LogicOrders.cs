using ManagePhones.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ManagePhones.Util.Exceptions;
using ManagePhones.Entities.Entidades;

namespace ManagePhones.Logic.Logic
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

        public async Task<RepairOrder> GetOrderData(RepairOrder order)
        {
            _orderRepository = new OrderRepository();
            try
            {
                return await _orderRepository.FindOneById(order.Id);
            }
            catch(SqlException sqlex)
            {
                throw new LoggedException();
            }
            catch(Exception ex)
            {
                throw new LoggedException();
            }
        }
    }
}
