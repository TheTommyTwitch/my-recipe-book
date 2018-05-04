using System;
namespace myrecipebook
{
    public class Recipe
    {
        //id,user_id,name,ingredients,instructions
        private int _id;
        private int _user_id;
        private string _name;
        private string _ingredients;
        private string _instructions;

        public Recipe(int id, int user_id, string name, string ingredients, string instructions)
        {
            this._user_id = user_id;
            this._name = name;
            this._ingredients = ingredients;
            this._instructions = instructions;
        }

        public int GetID()
        {
            return this._id;
        }

        public void SetID(int id)
        {
            this._id = id;
        }

        public int GetUserID()
        {
            return this._user_id;
        }

        public void SetUserID(int id)
        {
            this._user_id = id;
        }

        public string GetName()
        {
            return this._name;
        }

        public void SetName(string name)
        {
            this._name = name;
        }

        public string GetIngredients()
        {
            return this._ingredients;
        }

        public void SetIngredients(string ingredients)
        {
            this._ingredients = ingredients;
        }

        public string GetInstructions()
        {
            return this._instructions;
        }

        public void SetInstructions(string instructions)
        {
            this._instructions = instructions;
        }

    }
}
