using System;

namespace myrecipebook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDatabase db = new LocalData();

            Console.WriteLine("Options\n" +
                              "-----------------------------\n" +
                              "Press 1 to insert new recipe\n" +
                              "Press 2 to get a recipe by id\n" +
                              "Press 3 to get all recipes\n" +
                              "Press 4 to exit\n");
            

            while(true) {
                CommandLineInterface(db);
            }


        }

        private static void CommandLineInterface(IDatabase db) {
            Console.WriteLine("Selection option: \n");
            var input = Console.ReadLine();
            var num = int.Parse(input);

            switch (num)
            {
                case 1:
                    Recipe recipe = new Recipe();

                    Console.WriteLine("Enter recipe id: ");
                    input = Console.ReadLine();
                    var id = int.Parse(input);
                    recipe.SetID(id);

                    Console.WriteLine("Enter recipe name: ");
                    input = Console.ReadLine();
                    recipe.SetName(input);

                    Console.WriteLine("Enter recipe ingredients: ");
                    input = Console.ReadLine();
                    recipe.SetIngredients(input);

                    Console.WriteLine("Enter recipe instructions: ");
                    input = Console.ReadLine();
                    recipe.SetInstructions(input);

                    Console.WriteLine("Saved recipe: \n");
                    recipe.Print();

                    break;
                case 2:
                    Console.WriteLine("Enter recipe id: ");
                    input = Console.ReadLine();
                    id = int.Parse(input);
                    recipe = db.GetRecipe(id);
                    recipe.Print();
                    break;
                case 3:
                    var recipes = db.GetRecipes();
                    recipes.ForEach(delegate (Recipe rp)
                    {
                        rp.Print();
                    });
                    break;
                case 4:
                    Console.WriteLine("GoodBye");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Choose 1 - 4");
                    break;
            }
        }
    }
}
