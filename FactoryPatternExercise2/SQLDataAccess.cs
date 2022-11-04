using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from your SQL Database.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to your SQL Database.");
        }

        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "The Elder Scrolls III: Morrowind", Price = 59.99m },
            new Product() { Name = "Final Fantasy XII", Price = 49.99m },
            new Product() { Name = "Chrono Cross", Price = 39.99m },
            new Product() { Name = "Dark Souls", Price = 59.99m },
            new Product() { Name = "Xenogears", Price = 89.99m }
        };
    }
}
