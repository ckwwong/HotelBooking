using HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    public class HotelBooking : Controller
    {
        public IActionResult TestGuest()
        {
            HotelBookingModel TestGuest = new HotelBookingModel()
            { Id = 123, GuestName = "Bob", DateStart = "2008/03/05", DateEnd = "2008/03/20" };
            return View(TestGuest);  
        }
        public IActionResult HotelBookingDetails()
        {
            HotelBookingModel Guest = new HotelBookingModel()
            { Id = 123, GuestName = "Bob", DateStart = "2008/03/05", DateEnd = "2008/03/20" };
            return View(Guest);
        }
    }
}
