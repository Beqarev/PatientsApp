using System.Configuration;

namespace PatientsApp.DAL;

public class Context
{
    protected readonly string _connectionString;

    public Context()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    }
}