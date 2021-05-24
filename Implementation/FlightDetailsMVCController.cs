using NivyaBusinessLogic.Interface;
using NivyaDataAccess.Interface;
using NivyaDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivyaBusinessLogic.Implementation
{
    public class FlightDetailsMVCController : IFlightDetailsBusiness
    {
        private IFlightDetails _flightDetails;
        public FlightDetailsMVCController(IFlightDetails flightDetails)
        {
            _flightDetails  = flightDetails;
        }
        public Task<int> AddFlight(FlightDetails item)
        {


            
        }

        public IEnumerable<FlightDetails> GetFlightDetails()
        {
            throw new NotImplementedException();
        }

        public List<FlightDetails> SearchFlight(string source, string destination)
        {
            throw new NotImplementedException();
        }
    }
}
