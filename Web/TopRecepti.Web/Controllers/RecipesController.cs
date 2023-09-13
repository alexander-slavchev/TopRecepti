using Microsoft.AspNetCore.Mvc;
using TopRecepti.Web.ViewModels.Recipes;

namespace TopRecepti.Web.Controllers
{
    public class RecipesController : Controller
    {
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(CreateRecipeInputModel input)
        {
            if (this.ModelState.IsValid)
            {
                return this.View();
            }

            return this.Redirect("/");
        }
    }
}
