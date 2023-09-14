using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TopRecepti.Web.ViewModels.Recipes
{
    public class CreateRecipeInputModel
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }

        [Required]
        [MinLength(100)]
        public string Instructions { get; set; }

        [Display(Name = "Preparation time (in minutes)")]
        [Range(0, 24 * 60)]
        public TimeSpan PreparationTime { get; set; }

        [Range(0, 24 * 60)]
        [Display(Name = "Cooking time (in minutes)")]
        public TimeSpan CookingTime { get; set; }

        [Required]
        [Range(0.5, 100)]
        public int PortionCount { get; set; }

        public string Quantity { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<CreateRecipeInputModel> Ingredients { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoriesItems { get; set; }
        public string IngredientName { get; set; }
    }
}
