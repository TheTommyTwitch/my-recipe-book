using System;
using System.Collections.Generic;

namespace myrecipebook
{
    public class PostgresData : IDatabase
    {
        private string _connection;
        private Npgsql.NpgsqlConnection _conn;

        public PostgresData()
        {
            _connection = "Host=localhost;Username=;Password=;Database=recipe_book";
            _conn = new Npgsql.NpgsqlConnection(_connection);
        }

        public PostgresData(string conn) 
        {
            _connection = conn;
            _conn = new Npgsql.NpgsqlConnection(_connection);
        }

        public void CreateRecipe(Recipe recipe) {
            _conn.Open();

            // Insert some data
            using (var cmd = new Npgsql.NpgsqlCommand())
            {
                cmd.Connection = _conn;
                cmd.CommandText = "INSERT INTO recipes (name,ingredients,instructions) VALUES (@name, @ingr, @instr)";
                cmd.Parameters.AddWithValue("name", recipe.GetName());
                cmd.Parameters.AddWithValue("ingr", recipe.GetIngredients());
                cmd.Parameters.AddWithValue("instr", recipe.GetInstructions());
                cmd.ExecuteNonQuery();
            }

            _conn.Close();
        }

        public Recipe GetRecipe(int id)
        {
            _conn.Open();

            var data = new object[] { };
            // Retrieve all rows
            using (var cmd = new Npgsql.NpgsqlCommand("SELECT id, user_id, name, ingredients, instructions FROM recipes WHERE id = @id LIMIT 1", _conn)) 
            {
                cmd.Parameters.AddWithValue("id", id);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    reader.GetValues(data);
                        Console.WriteLine(reader.GetString(0));
            }

            _conn.Close();

            return new Recipe(int.Parse(data[0].ToString()), data[1].ToString(), data[2].ToString(), data[3].ToString());
        }

        public void UpdateRecipe(Recipe recipe)
        {
            _conn.Open();

            using (var cmd = new Npgsql.NpgsqlCommand())
            {
                cmd.Connection = _conn;
                cmd.CommandText = "UPDATE recipes SET (user_id,name,ingredients,instructions) = (@uid, @name, @ingr, @instr) WHERE id = @id";
                cmd.Parameters.AddWithValue("id", recipe.GetID());
                cmd.Parameters.AddWithValue("name", recipe.GetName());
                cmd.Parameters.AddWithValue("ingr", recipe.GetIngredients());
                cmd.Parameters.AddWithValue("instr", recipe.GetInstructions());
                cmd.ExecuteNonQuery();
            }

            _conn.Close();
        }

        public void DeleteRecipe(Recipe recipe)
        {
            _conn.Open();

            // Insert some data
            using (var cmd = new Npgsql.NpgsqlCommand())
            {
                cmd.Connection = _conn;
                cmd.CommandText = "DELETE from recipes where id = @id";
                cmd.Parameters.AddWithValue("id", recipe.GetID());
                cmd.ExecuteNonQuery();
            }

            _conn.Close();
        }

        public List<Recipe> GetRecipes()
        {
            _conn.Open();

            var recipes = new List<Recipe>{};
            var data = new object[] { };
            // Retrieve all rows
            using (var cmd = new Npgsql.NpgsqlCommand("SELECT id, user_id, name, ingredients, instructions FROM recipes", _conn))
            {
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    reader.GetValues(data);
                    recipes.Add(new Recipe(int.Parse(data[0].ToString()), data[1].ToString(), data[2].ToString(), data[3].ToString()));
                    data = new object[] { };
            }

            _conn.Close();

            return recipes;
        }

    }
}

