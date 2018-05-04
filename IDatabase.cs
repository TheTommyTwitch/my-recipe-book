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
        List<Recipe> GetRecipes(int user_id);
        void CreateUser(User user);
        User GetUser(int id);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
