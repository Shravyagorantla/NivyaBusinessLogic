using NivyaBusinessLogic.Interface;
using NivyaDataAccess.Interface;
using NivyaDataAccess.Model;
using NivyaDataAccess.Repo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivyaBusinessLogic.Implementation
{

    public class RegistrationMVCController : IRegistrationMVCController

    {
        private IRegistration _registration;
        public RegistrationMVCController (IRegistration registration)
        {
            _registration = registration;
        }


        RegistrationRepo registrationRepo = new RegistrationRepo();

        SqlCommand command = new SqlCommand();



     
        public IEnumerable<Registration> GetRegistrations()
        {
            return Registration.ToList();
           // throw new NotImplementedException();
        }

        public  async Task<int> PostRegistrationDetails(Registration item)
        {
            try
            {

                return await registrationRepo.AddUser(item);
            }
            catch
            {
                throw;  
            
            }

        }

        /*public Task<int> PostRegistrationDetails(Registration item)
        {
            throw new NotImplementedException();
        }*/
    }
}
