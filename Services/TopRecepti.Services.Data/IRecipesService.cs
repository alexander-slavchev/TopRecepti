namespace TopRecepti.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TopRecepti.Web.ViewModels.Recipes;

    public interface IRecipesService
    {
        Task CreateAsync(CreateRecipeInputModel input, string userId);

        IEnumerable<RecipeInListViewModel> GetAll(int page, int itemsPerPage = 12);
    }
}
