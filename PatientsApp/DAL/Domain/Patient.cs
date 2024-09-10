#nullable enable
using System;

namespace PatientsApp.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Dob { get; set; }
        public int GenderID { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PersonalNumber { get; set; }
    }
}