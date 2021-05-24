/*using NivyaBusinessLogic.Interface;
using NivyaDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace NivyaBusinessLogic
{
    public class RegistrationBusiness : IRegistrationBusiness
    {

        public IEnumerable<Registration> GetRegistrationDetails()
        {
            return Registration.ToList();

        }

        [HttpPost]
        public static async Task<int> AddUser(Registration item)
        {
           
            
            Registration reg = null;
            if (item == null)
            {
                throw new NullReferenceException();
            }
            else

            {
                reg = new Registration()
                {
                    Username = item.Username,
                    Email = item.Email,
                    MobileNumber = item.MobileNumber,
                    Password = item.Password
                };
                string id = item. where(x => x.Username).ToList();
                reg.Username = id + 1;

                }
            return reg;

        }

        Task<int> IRegistrationBusiness.AddUser(Registration item)
        {
            throw new NotImplementedException();
        }
    }

}
*/