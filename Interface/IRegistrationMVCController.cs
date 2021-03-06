using NivyaDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivyaBusinessLogic.Interface
{
    public interface IRegistrationMVCController
    {
        IEnumerable<Registration> GetRegistrations();

        Task<int> PostRegistrationDetails(Registration item);
    }
}
