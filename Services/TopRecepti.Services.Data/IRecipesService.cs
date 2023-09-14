namespace TopRecepti.Services.Data
{
    using System.Threading.Tasks;
    using TopRecepti.Web.ViewModels.Recipes;

    public interface IRecipesService
    {
        Task CreateAsync(CreateRecipeInputModel input);
    }
}
