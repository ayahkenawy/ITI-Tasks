using Api_Car.Filters;
using Api_Car.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_Car.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [DiscontinueOldVersion]
    public class CarController : ControllerBase
       {
        private static List<Car> _cars = new List<Car>()
        {
           new Car(){Id=1,Model="BMW2015",Name="BMW",ProductionDate= new DateTime(2015,04,04),Type="BMW"},
           new Car(){Id=2,Model="HUNDA2012",Name="HUNDA",ProductionDate= new DateTime(2012,04,04),Type="HUNDA"},
           new Car(){Id=3,Model="Mercedes2016",Name="Mercedes",ProductionDate= new DateTime(2016,04,04),Type="Mercedes"},
           new Car(){Id=4,Model="Hundai2015",Name="Hundai",ProductionDate= new DateTime(2015,04,04),Type="Hundai"},
        };
        public CarController()
        {
                
        }
        [HttpGet]
        public  ActionResult<List<Car>> GetAll()
        {
            return _cars;
        }
        [HttpGet]
        [Route("{id:int:min(1)}")]
        public ActionResult<List<Car>> GetById(int id)
        {
           
            if ( _cars.Where(w => w.Id == id)==null)
            {
                return NotFound();
            }
            return _cars.Where(w => w.Id == id).ToList();
        }

        [HttpPut]
        [Route("{id:int:min(1)}")]
        public ActionResult Update([FromBody]Car input, int id)
        {
            if (id != input.Id)
            {
                return BadRequest(new { ErrorCode = 5 });
            }
            if (_cars.Where(w => w.Id == id) == null)
            {
                return NotFound(new { Message = "The resource you're looking for is not found." });
            }

            _cars.Where(w => w.Id == id).First().Name = input.Name;
            _cars.Where(w => w.Id == id).First().Type = input.Type;
            _cars.Where(w => w.Id == id).First().Model = input.Model;
            _cars.Where(w => w.Id == id).First().ProductionDate = input.ProductionDate;
            return NoContent();
        }
        [HttpDelete]
        [Route("{id:min(1)}")]
        public ActionResult Delete(int id)
        {
            if (_cars.Where(w => w.Id == id) == null)
            {
                return NotFound();
            }
            _cars.Remove(_cars.Where(w => w.Id == id).First());
            return NoContent();
        }
        [HttpPost]
        [ModelValidation]
        public ActionResult Add([FromBody]Car AddCar)
        {
            // AddCar.Id = new Random().Next(1,1000);
            AddCar.Id = _cars.Count + 1;
            AddCar.Type = "Gas";
            _cars.Add(AddCar);
            return CreatedAtAction(
            actionName: nameof(GetById),
            routeValues: new { id = AddCar.Id },
            value: "Thanks for adding a new car");
        }
        [HttpPost]
        [Route("AddNV")]
        [TypeValidation]
        [ModelValidation]
        public ActionResult AddNewVersion([FromBody] Car AddCar)
        {
            AddCar.Id = _cars.Count +1;
            _cars.Add(AddCar);
            return CreatedAtAction(
            actionName: nameof(GetById),
            routeValues: new { id = AddCar.Id },
            value: "Thanks for adding a new car");
        }
        [HttpGet]
        [Route("counter")]
        public ActionResult<int> counter()
        {
           return Program.counter;
        }

    }
}
 