using System.ComponentModel.DataAnnotations;

namespace BikeStore.Models
{
    public enum ProductType
    {
        bicycle, part, clothing
    }
        
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Display(Name = "Procucent")]
        public string Producer { get; set; }

        [Display(Name = "Zdjęcie")]
        public string URLToPhoto { get; set; }

        [Required]
        [Display(Name = "Cena")]
        public decimal Price { get; set; }

        [Display(Name = "Opis")]
        public string Description { get; set; }


        [Display(Name = "Typ produktu")]
        public ProductType ProductType { get; set; }
    }
}
