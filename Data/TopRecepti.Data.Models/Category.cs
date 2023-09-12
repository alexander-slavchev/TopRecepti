namespace TopRecepti.Data.Models
{
    using System.Collections.Generic;

    using TopRecepti.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public ICollection<Recipe> Recipes { get; set; }
    }
}
