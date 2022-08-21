using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Models
{
    public class HotelBooking
    {
        public int Id { get; set; } 

        public string GuestName { get; set; }

        public DateTime CreatedDate { get; set; }   

        public DateTime DateEnd { get; set; }
        
    }
}
