using System;
using System.Collections.Generic;

namespace myrecipebook
{
    public class LocalData : IDatabase
    {
        private List<Recipe> _recipes;

        public LocalData()
        {
            this._recipes = new List<Recipe> { };
        }

        public void CreateRecipe(Recipe recipe)
        {
            _recipes.Add(recipe);
        }

        public Recipe GetRecipe(int id)
        {
            foreach (var rp in _recipes)
            {
                if (rp.GetID() == id)
                {
                    return rp;
                }
            }

            return null;
        }

        public void UpdateRecipe(Recipe recipe)
        {
            foreach (var rp in _recipes)
            {
                if (rp.GetID() == recipe.GetID())
                {
                    rp.SetID(recipe.GetID());
                    rp.SetName(recipe.GetName());
                    rp.SetIngredients(recipe.GetIngredients());
                    rp.SetInstructions(recipe.GetInstructions());
                    break;
                }
            }
        }

        public void DeleteRecipe(Recipe recipe)
        {
            foreach (var rp in _recipes)
            {
                if (rp.GetID() == recipe.GetID())
                {
                    _recipes.Remove(rp);
                    break;
                }
            }
        }

        public List<Recipe> GetRecipes()
        {
            return _recipes;
        }


    }
}

