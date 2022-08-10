using Api_Car.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Api_Car.Filters
{
    public class DiscontinueOldVersionAttribute : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
           // var controller = context.RouteData.Values["controller"];
            var action = context.RouteData.Values["action"] as string;
            if(action == nameof(CarController.Add))
            {
                context.ModelState.AddModelError("Add", "This EndPoint Not Allowed Any more");
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }
}
