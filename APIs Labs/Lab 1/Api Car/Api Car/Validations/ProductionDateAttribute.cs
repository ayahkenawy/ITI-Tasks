using System.ComponentModel.DataAnnotations;

namespace Api_Car.Validations
{
    public class ProductionDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            return value is DateTime date && date <= DateTime.Now;
        }
    }
}
