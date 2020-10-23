using System.Configuration;

namespace DALImplementations
{
    public class BaseDao
    {
        protected string _connectionString = ConfigurationManager.ConnectionStrings["EstateAgency"].ConnectionString;
    }
}