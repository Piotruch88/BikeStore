using System;
using System.ComponentModel.DataAnnotations;

namespace BikeStore.Models
{
    public enum OrderStatus
    {

    }
    
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Status zamówienia")]
        public OrderStatus Status { get; set; }
        [Required]
        [Display(Name = "Data założenia zamówienia")]
        [DisplayFormat(DataFormatString = "{0:dd MMMM}")]
        public DateTime TimeCreate { get; set; }

        [Display(Name = "Zamawiający")]
        [Required]
        public string UserPurchaser { get; set; }
        public virtual ApplicationUser Purchaser { get; set; }

        [Display(Name = "Adres zamówienia")]
        public string Addres { get; set; }

        [Required]
        public Guid Guid { get; set; }
    }
}
