namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What data base would you like to use? List, SQL, or Mongo");
                var response = Console.ReadLine(); 

            IDataAccess da = DataAccessFactory.GetDataAccessType(response);

            //or var da = DataAccessFactory.GetDataAccessType(response);
            //IDataAccess da = new ListDataAccess();
            //IdataAccess da = new SQLData Access();
            //IDataAccess da = new MongoDataAccess();

            var products = da.LoadData();

            Console.WriteLine("Here are your Products:");

            foreach (var item in products) 
            {
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Price: {item.Price}");
            }

            da.SaveData();
        }
    }
}
