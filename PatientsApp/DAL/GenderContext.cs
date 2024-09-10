using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using PatientsApp.DAL;

namespace PatientsApp.Models;

public class GenderContext : Context
{
    public IEnumerable<Gender> GetAll()
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string storedProcedureName = "GetAllGenders";
            return connection.Query<Gender>(storedProcedureName, commandType: CommandType.StoredProcedure).ToList();
        }
    }
}