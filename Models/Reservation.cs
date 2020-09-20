using System;
namespace ExpressoAPI.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int TotalPeople { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }

        public Reservation()
        {

        }
    }
}