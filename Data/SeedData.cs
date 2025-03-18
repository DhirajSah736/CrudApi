using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CrudApi.Models;
using System;

namespace CrudApi.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (!context.Recipes.Any())
                {
                    context.Recipes.AddRange(
                        new Recipe
                        {
                            RecipeName = "Pasta",
                            Ingredients = "Pasta, Tomato Sauce, Cheese",
                            Instructions = "Boil pasta, mix with sauce, add cheese",
                            Category = "Italian"
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
