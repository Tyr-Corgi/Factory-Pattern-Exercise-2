using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoAccess : IDataAccess
    {
        public MongoAccess()
        {
            
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("LOading data from MongoDb");
            return new List<Product>()
            {
                new Product() { Name = "PLaydouigh", Price = 10.00},
                new Product() {Name = "Crayons", Price =5.00 }
            };
        }

        public void SaveData()
        {
            Console.WriteLine();
        }
    }
}
