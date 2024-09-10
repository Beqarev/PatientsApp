using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using PatientsApp.DAL;
using PatientsApp.Interfaces;
using PatientsApp.Models;

namespace PatientsApp.Repositories;

public class PatientRepository : IPatientRepository
{
    private readonly PatientContext _context = new PatientContext();

    public IEnumerable<PatientInfo> GetAllPatients()
    {
        return _context.GetAll();
    }

    public Patient GetPatientById(int id)
    {

        return _context.GetById(id);
    }

    public void AddPatient(Patient patient)
    {
        _context.Add(patient);
    }

    public void UpdatePatient(Patient patient, int id)
    {
        _context.Update(patient, id);
    }

    public void DeletePatient(int id)
    {
        
        _context.Delete(id);
    }
}