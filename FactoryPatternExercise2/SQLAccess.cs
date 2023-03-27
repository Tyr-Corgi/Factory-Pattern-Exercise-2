using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class SQLAccess : IDataAccess
    {
        public SQLAccess()
        {

        }


        public List<Product> LoadData()
        {
            Console.WriteLine("Reading grfom the SQL Data Base");
            return new List<Product>()
            {
                new Product() {Name = "SLinky", Price = 3.00},
                new Product() {Name = "Rubik's Cude", Price = 5 }
            };
        }

        public void SaveData()
        {
            throw new NotImplementedException();
        }
    }
}
