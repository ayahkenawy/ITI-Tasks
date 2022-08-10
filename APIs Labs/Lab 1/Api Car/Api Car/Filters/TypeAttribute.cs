using Api_Car.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.RegularExpressions;

namespace Api_Car.Filters
{
    public class TypeValidationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            var AllowedTypes = new Regex("^(Electric|Gas|Diesel|Hybrid)$",
                RegexOptions.None, TimeSpan.FromSeconds(3));
            Car? car = context.ActionArguments["AddCar"] as Car;
            if (car is null || !AllowedTypes.IsMatch(car.Type))
            {
                context.ModelState.AddModelError("Type", "Type Not Allowed");
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }

    }
}
