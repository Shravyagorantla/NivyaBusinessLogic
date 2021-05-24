using NivyaBusinessLogic.Interface;
using NivyaDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivyaBusinessLogic.Implementation
{
    public class BookingDetailsMVCController : IBookingDetailsMVCController
    {
        public Task<int> AddBooking(BookingDetails item)
        {

           
        }

        public BookingDetails GetBookingDetails()
        {
            throw new NotImplementedException();
        }
    }
}
