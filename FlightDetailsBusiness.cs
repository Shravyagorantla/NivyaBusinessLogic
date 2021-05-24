/*using NivyaDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivyaBusinessLogic
{
    public class FlightDetailsBusiness
    {
        public IEnumerable<FlightDetails> GetFlightDetails()
        {
            return FlightDetails.Tolist();
        
        }

        public Task<int> AddFlight(FlightDetails item)
        {

            FlightDetails fd = null;
            if (item == null)
            {
                throw new NullReferenceException();
            }
            else

            {
                fd = new FlightDetails()
                {
                    FlightNo = item.FlightNo,
                    FlightName = item.FlightName,
                    Source = item.Source,
                    Destination = item.Destination,
                    Arrival = item.Arrival,
                    Departure = item.Departure,
                    Date = item.Date,
                    SeatType = item.SeatType,
                    NoOfSeats = item.NoOfSeats,
                    Price = item.Price,
                };
                int id = Registration.Max(x => x.FlightNo);
                fd.FlightNo = id + 1;

            }
            return fd;



        }
    }
}
*/