using System.Collections.Generic;
using PatientsApp.Interfaces;
using PatientsApp.Models;

namespace PatientsApp.Repositories;

public class GenderRepository : IGenderRepository
{
    private readonly GenderContext _context = new GenderContext();
    
    public IEnumerable<Gender> GetAllGenders()
    {
        return _context.GetAll();
    }
}