using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using PatientsApp.Models;

namespace PatientsApp.DAL;

public class PatientContext : Context
{
    public IEnumerable<PatientInfo> GetAll()
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string storedProcedureName = "GetPatients";
            return connection.Query<PatientInfo>(storedProcedureName, commandType: CommandType.StoredProcedure).ToList();
        }
    }
    
    public Patient GetById(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string storedProcedureName = "GetPatientById";
            var parameters = new { ID = id };
            return connection.QueryFirstOrDefault<Patient>(storedProcedureName, parameters, commandType: CommandType.StoredProcedure);
        }
    }
    
    public void Add(Patient patient)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string storedProcedureName = "AddPatient";
            var parameters = new
            {
                FullName = patient.FullName,
                Dob = patient.Dob,
                GenderID = patient.GenderID,
                Phone = patient.Phone ?? (object)DBNull.Value,
                Address = patient.Address ?? (object)DBNull.Value,
                Email = patient.Email ?? (object)DBNull.Value,
                PersonalNumber = patient.PersonalNumber ?? (object)DBNull.Value
            };
            connection.Execute(storedProcedureName, parameters, commandType: CommandType.StoredProcedure);
        }
    }

    public void Update(Patient patient, int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string storedProcedureName = "UpdatePatient";
            var parameters = new
            {
                ID = patient.Id,
                FullName = patient.FullName,
                Dob = patient.Dob,
                GenderID = patient.GenderID,
                Phone = patient.Phone,
                Address = patient.Address,
                Email = patient.Email,
                PersonalNumber = patient.PersonalNumber
            };
            connection.Execute(storedProcedureName, parameters, commandType: CommandType.StoredProcedure);
        }
    }

    public void Delete(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string storedProcedure = "DeletePatient";
            var parameters = new { ID = id };
            connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}