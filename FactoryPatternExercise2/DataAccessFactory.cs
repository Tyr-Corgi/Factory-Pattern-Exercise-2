using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(String databaseType)
        {
            switch (databaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                case "my sql":
                    return new SQLAccess();
                case "mongo":
                    case "mongodb":
                    return new MongoAccess();
                default:
                    return new ListDataAccess();
            }
        }
    }
}
