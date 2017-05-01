using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entidades;
using DataAccess.Repositories;
using System.Data.SqlClient;
using Util.Exceptions;

namespace Logic.Logic
{
    public class LogicPhone
    {
        PhoneRepository _phoneRepository;

        public async Task AddNewPhone(Phone phone)
        {
            _phoneRepository = new PhoneRepository();
            try
            {
                await _phoneRepository.Insert(phone);
            }
            catch(SqlException sqlex)
            {
                throw new LoggedException();
            }
            catch(Exception ex)
            {
                throw new LoggedException();
            }
            finally
            {
                _phoneRepository = null;
            }
        }

        public async Task UpdatePhone(Phone phone)
        {
            _phoneRepository = new PhoneRepository();
            try
            {
                await _phoneRepository.Update(phone);
            }
            catch (SqlException sqlex)
            {
                throw new LoggedException();
            }
            catch (Exception ex)
            {
                throw new LoggedException();
            }
            finally
            {
                _phoneRepository = null;
            }
        }
    }
}
