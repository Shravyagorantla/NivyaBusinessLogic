using NivyaDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivyaBusinessLogic.Interface
{
    public interface IBookingDetailsMVCController
    {
        BookingDetails GetBookingDetails();
        Task<int> AddBooking(BookingDetails item);
    }
    

}
