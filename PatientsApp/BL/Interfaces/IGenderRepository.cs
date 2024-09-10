using System.Collections.Generic;
using PatientsApp.Models;

namespace PatientsApp.Interfaces;

public interface IGenderRepository
{
    IEnumerable<Gender> GetAllGenders();
}