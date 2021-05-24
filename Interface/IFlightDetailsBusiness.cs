using NivyaDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivyaBusinessLogic.Interface
{
     public interface IFlightDetailsBusiness
    {
        IEnumerable<FlightDetails>  GetFlightDetails();
        Task<int> AddFlight(FlightDetails item);
        List<FlightDetails> SearchFlight(string source, string destination);
    }
}
