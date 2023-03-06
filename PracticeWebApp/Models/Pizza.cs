using System.ComponentModel.DataAnnotations;

namespace PracticeWebApp.Models
{
    public class Pizza
    {
        public string Id { get; set; }

        [Required]
        public string ? Name { get; set; }
        public bool isGlutenFree { get; set; }

        [Range(0, 500)]
        public decimal Price { get; set; }
    }
}
