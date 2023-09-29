namespace TopRecepti.Web.ViewModels.Recipes
{
    using TopRecepti.Data.Models;
    using TopRecepti.Services.Mapping;

    public class IngredientsViewModel : IMapFrom<RecipeIngredient>
    {
        public string IngredientName { get; set; }

        public string Quantity { get; set; }
    }
}
