using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using lab3.ViewModels;
using lab3.Models;
using lab3.Data;

namespace lab3.Services
{
    public class TakeLast
    {
        public static HomeViewModel GetHomeViewModel()
        {
            HomeViewModel homeViewModel = null;
            Thread.Sleep(2000);
            using (Context _context = new Context())
            {
                List<Disease> diseases = _context.Diseases.OrderByDescending(p => p.DiseaseID).Take(10).ToList();
                List<Medicine> medicines = _context.Medicines.OrderByDescending(p => p.MedicineID).Take(10).ToList();
                List<Treatment> treatments = _context.Treatmens.OrderByDescending(p => p.TreatmentID).Take(10).ToList();
                List<Patient> patients = _context.Patients.OrderByDescending(p => p.PatientID).Take(10).ToList();
                homeViewModel = new HomeViewModel {
                    Patients = patients,
                    Diseases = diseases,
                    Medicines = medicines,
                    Treatmens = treatments
                };
            }

            return homeViewModel;
        }
    }
}
