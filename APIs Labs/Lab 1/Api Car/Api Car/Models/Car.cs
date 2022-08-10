using Api_Car.Validations;
using System.ComponentModel.DataAnnotations;

namespace Api_Car.Models
{
    public class Car
    {
        [Range(1,int.MaxValue)]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Model { get; set; } = "";
        [ProductionDate]
        public DateTime ProductionDate { get; set; }
       // [Required]
        public string Type { get; set; } = "";
    }
}
