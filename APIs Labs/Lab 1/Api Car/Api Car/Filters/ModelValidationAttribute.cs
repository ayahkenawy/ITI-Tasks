using Api_Car.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Api_Car.Filters
{
    public class ModelValidationAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            Car? car = context.ActionArguments["AddCar"] as Car;
            if (car is null || (car.Model== "Tesla"&& car.ProductionDate <=new DateTime(2008,01,01)))
            {
                context.ModelState.AddModelError("ProductionDate", "ProductionDate Should Be Newer Than 2008");
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }
}
