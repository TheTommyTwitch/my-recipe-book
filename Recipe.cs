using System;
namespace myrecipebook
{
    public class Recipe
    {
        private int _id;
        private string _name;
        private string _ingredients;
        private string _instructions;

        public Recipe()
        {
            _id = 0;
            _name = "";
            _ingredients = "";
            _instructions = "";
        }

        public Recipe(int id, string name, string ingredients, string instructions)
        {
            this._id = id;
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

        public void Print()
        {
            Console.WriteLine("ID: " + this._id + "\n");
            Console.WriteLine("Name: " + this._name + "\n");
            Console.WriteLine("Ingredients: " + this._ingredients + "\n");
            Console.WriteLine("Instructions: " + this._instructions + "\n");
        }

    }
}
