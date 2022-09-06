using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using FoodStoreApp.Data;

namespace FoodStoreApp.Models
{
    public class Manufacture
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string Description { get; set; }
        public string? Rating { get; set; }
    }
}
