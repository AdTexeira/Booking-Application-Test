using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResortBookingApp
{
    public class Bookings
    {
        public int ID { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BookingDate { get; set; }
        [DataType(DataType.Text,ErrorMessage ="Please enter a number!")]
        public int NumOfppl { get; set; }
        [DataType(DataType.Currency, ErrorMessage = "Please enter a number!")]
        public decimal Price { get; set; }
    }
}
