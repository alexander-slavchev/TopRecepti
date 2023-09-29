using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopRecepti.Data.Models;

namespace TopRecepti.Data.Seeding
{
    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Categories.AddAsync(new Category { Name = "Чушка" });
            await dbContext.Categories.AddAsync(new Category { Name = "Торта" });
            await dbContext.Categories.AddAsync(new Category { Name = "Свинско" });
            await dbContext.Categories.AddAsync(new Category { Name = "Телешко" });

            await dbContext.SaveChangesAsync();
        }
    }
}
