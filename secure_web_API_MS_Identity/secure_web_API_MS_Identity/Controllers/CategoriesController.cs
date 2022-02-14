using System.Collections.Generic;
using System.Linq;
using secure_web_API_MS_Identity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace secure_web_API_MS_Identity.Controllers
{
    // The controller has the [Authorize] attribute,
    // which forces the request to have a valid
    // Authorization header in the request.
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        SampleData data;
        public CategoriesController(SampleData data)
        {
            this.data = data;
        }
        
        [HttpGet]
        public List<Category> GetAllCategories()
        {
            // Each action method makes a call to
            // the VerifyUserHasAnyAcceptedScope()
            // method, specifying the scope required
            // to execute the action. E.g. here "Category.Read"
            HttpContext.VerifyUserHasAnyAcceptedScope(new string[] { "Category.Read" });
            return data.Categories;
        }

        [HttpGet("{id}")]
        public Category GetCategory(int id)
        {
            HttpContext.VerifyUserHasAnyAcceptedScope(new string[] { "Category.Read" });
            return data.Categories.FirstOrDefault(p => p.Id.Equals(id));
        }

        [HttpPost]
        public ActionResult CreateCategory([FromBody] Category newCategory)
        {
            HttpContext.VerifyUserHasAnyAcceptedScope(new string[] { "Category.Write" });
            if (string.IsNullOrEmpty(newCategory.Name))
            {
                return BadRequest("Product Name cannot be empty");
            }
            newCategory.Id = (data.Categories.Max(c => c.Id) + 1);
            data.Categories.Add(newCategory);
            return CreatedAtAction(nameof(GetCategory), new { id = newCategory.Id }, newCategory);
        }
    }
}
