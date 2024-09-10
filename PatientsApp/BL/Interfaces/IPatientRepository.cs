using System.Collections.Generic;
using PatientsApp.Models;

namespace PatientsApp.Interfaces;

public interface IPatientRepository
{
    IEnumerable<PatientInfo> GetAllPatients();
    Patient GetPatientById(int id);
    void AddPatient(Patient patient);
    void UpdatePatient(Patient patient, int id);
    void DeletePatient(int id);
}