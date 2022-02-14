using webapi_vs.Models;
using webapi_vs.Services;
using Microsoft.AspNetCore.Mvc;

namespace webapi_vs.Controllers
{
    // Note: since this controller class is named PizzaController,
    // requests to /pizza are handled by this controller
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        PizzaService _pizzaService;
        public PizzaController(PizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        public IEnumerable<Pizza> GetAll()
        {
            return _pizzaService.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Pizza> GetById(int id)
        {
            var pizza = _pizzaService.GetById(id);

            if (pizza is not null)
            {
                return pizza;
            }
            else
            {
                return NotFound();
            }
        }


        [HttpPost]
        public IActionResult Create(Pizza newPizza)
        {
            var pizza = _pizzaService.Create(newPizza);
            return CreatedAtAction(nameof(GetById), new { id = pizza!.Id }, pizza);
        }

        [HttpPut("{id}/addtopping")]
        public IActionResult AddTopping(int id, int toppingId)
        {
            var pizzaToUpdate = _pizzaService.GetById(id);

            if (pizzaToUpdate is not null)
            {
                _pizzaService.AddTopping(id, toppingId);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{id}/updatesauce")]
        public IActionResult UpdateSauce(int id, int sauceId)
        {
            var pizzaToUpdate = _pizzaService.GetById(id);

            if (pizzaToUpdate is not null)
            {
                _pizzaService.UpdateSauce(id, sauceId);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pizza = _pizzaService.GetById(id);

            if (pizza is not null)
            {
                _pizzaService.DeleteById(id);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

    }
}
