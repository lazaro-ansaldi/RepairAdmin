using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ManagePhones.DataAccess.Repositories;
using System.Data.SqlClient;
using ManagePhones.Util.Exceptions;
using ManagePhones.Entities.Entidades;

namespace ManagePhones.Logic.Logic
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

        public async Task<IEnumerable<Phone>> GetAll()
        {
            _phoneRepository = new PhoneRepository();
            try
            {
                return await _phoneRepository.GetAll();
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
