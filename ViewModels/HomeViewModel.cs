using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using lab3.Models;

namespace lab3.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Disease> Diseases { get; set; }
        public IEnumerable<Medicine> Medicines { get; set; }
        public IEnumerable<Patient> Patients { get; set; }
        public IEnumerable<Treatment> Treatmens { get; set; }
    }
}
