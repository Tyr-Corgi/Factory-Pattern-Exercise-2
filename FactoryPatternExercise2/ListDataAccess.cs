using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("Reading data from your list:");
            return new List<Product>()
            { new Product() {Name = "Pogo stick", Price = 25.00},
                new Product() { Name = "Skateboard, Price = 50.00"}
            };

        }

        public void SaveData()
        {
                Console.WriteLine("saving data to the List");
        }
    }
}
