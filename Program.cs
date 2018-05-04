using System;

namespace myrecipebook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string creds = "Host=localhost;Username=;Password=;Database=recipe_book";

            IDatabase db = new PostgresData(creds);

            System.Console.WriteLine("23efwrgerger");


        }
    }
}
