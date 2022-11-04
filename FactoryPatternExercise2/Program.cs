namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello, what database would you like to use?");
            Console.WriteLine("List, SQL, or Mongo?");
            string userInput = Console.ReadLine();
            var userDataType = DataAccessFactory.GetDataAccessType(userInput);
            List<Product> products = userDataType.LoadData();
            Thread.Sleep(500);
            Console.WriteLine(".");
            Thread.Sleep(500);
            Console.WriteLine("..");
            Thread.Sleep(500);
            Console.WriteLine("...");
            
            for(int index = 0; index < products.Count; index++)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Product name: {products[index].Name}");
                Console.WriteLine($"Product price: ${products[index].Price}");
                Console.WriteLine("----------------------------------------");
            }

            userDataType.SaveData();
            Console.ReadLine();
        }
    }
}
