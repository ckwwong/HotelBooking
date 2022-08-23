using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Models
{
    public class HotelBookingModel
    {
        public int Id { get; set; } 

        public string GuestName { get; set; }

        public string DateStart { get; set; }   

        public String DateEnd { get; set; }
        
    }
}
