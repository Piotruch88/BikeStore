using System;
using System.ComponentModel.DataAnnotations;

namespace BikeStore.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Data założenia zamówienia")]
        [DisplayFormat(DataFormatString = "{0:dd MMMM}")]
        public DateTime TimeCreate { get; set; }

        [Display(Name = "Zamawiający")]
        [Required]
        public string UserIdPlacing { get; set; }
        
        [Display(Name = "Adres do wysyłki zamówienia")]
        public string Addres { get; set; }

        [Required]
        public Guid Guid { get; set; }
    }
}
