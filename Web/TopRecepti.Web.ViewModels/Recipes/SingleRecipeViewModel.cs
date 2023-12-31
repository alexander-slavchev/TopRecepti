﻿namespace MoiteRecepti.Web.ViewModels.Recipes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using TopRecepti.Data.Models;
    using TopRecepti.Services.Mapping;
    using TopRecepti.Web.ViewModels.Recipes;

    public class SingleRecipeViewModel : IMapFrom<Recipe>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CategoryName { get; set; }

        public DateTime CreatedOn { get; set; }

        public string AddedByUserEmail { get; set; }

        public string ImageUrl { get; set; }

        public string Instructions { get; set; }

        public TimeSpan PreparationTime { get; set; }

        public TimeSpan CookingTime { get; set; }

        public int PortionsCount { get; set; }

        public int CategoryRecipesCount { get; set; }

        public string OriginalUrl { get; set; }

        public double AverageVote { get; set; }

        public IEnumerable<IngredientsViewModel> Ingredients { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Recipe, SingleRecipeViewModel>()
                .ForMember(x => x.AverageVote, opt =>
                    opt.MapFrom(x => x.Votes.Count == 0 ? 0 : x.Votes.Average(v => v.Value)))
                 .ForMember(x => x.ImageUrl, opt =>
                opt.MapFrom(r =>
                    r.Images.FirstOrDefault().RemoteImageUrl != null ?
                    r.Images.FirstOrDefault().RemoteImageUrl :
                    "/images/recipes/" + r.Images.FirstOrDefault().Id + "." + r.Images.FirstOrDefault().Extension));
        }
    }
}