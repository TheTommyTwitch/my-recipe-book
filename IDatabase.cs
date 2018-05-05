using System;
using System.Collections.Generic;

namespace myrecipebook
{
    public interface IDatabase
    {
        void CreateRecipe(Recipe recipe);
        Recipe GetRecipe(int id);
        void UpdateRecipe(Recipe recipe);
        void DeleteRecipe(Recipe recipe);
        List<Recipe> GetRecipes();
    }
}
