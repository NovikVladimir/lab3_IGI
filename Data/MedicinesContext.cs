using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab3.Models;

namespace lab3.Data
{
    public class MedicinesContext
    {
        public static List<Medicine> GetAll()
        {
            List<Medicine> all = new List<Medicine>();
            using (Context db = new Context())
            {
                all = db.Medicines.ToList();
            }

            return all;
        }

        public static void AddMedicine(Medicine medicine)
        {
            using (Context db = new Context())
            {
                db.Medicines.Add(medicine);
                db.SaveChanges();
            }
        }

        public static void UpdataMedicine(Medicine medicine)
        {
            using (Context db = new Context())
            {
                if (medicine != null)
                {
                    db.Medicines.Update(medicine);
                    db.SaveChanges();
                }
            }
        }

        public static void DeleteMedicine(Medicine medicine)
        {
            using (Context db = new Context())
            {
                if (medicine != null)
                {
                    db.Medicines.Remove(medicine);
                    db.SaveChanges();
                }
            }
        }

        public static List<Medicine> FindMedicine(string medicineName, string medicineIndications,
            string medicineManufacturer, string medicineDosage)
        {
            List<Medicine> medicines = new List<Medicine>();
            using (Context db = new Context())
            {
                if (medicineName != null && medicineName != "")
                {
                    medicines = db.Medicines.Where(k => k.MedicineName == medicineName).ToList();
                }
                if (medicineIndications != null && medicineIndications != "")
                {
                    if (medicines.Count != 0)
                    {
                        medicines = medicines.Where(k => k.MedicineIndications == medicineIndications).ToList();
                    }
                    else
                    {
                        medicines = db.Medicines.Where(k => k.MedicineIndications == medicineIndications).ToList();
                    }
                }
                if (medicineManufacturer != null && medicineManufacturer != "")
                {
                    if (medicines.Count != 0)
                    {
                        medicines = medicines.Where(k => k.MedicineManufacturer == medicineManufacturer).ToList();
                    }
                    else
                    {
                        medicines = db.Medicines.Where(k => k.MedicineManufacturer == medicineManufacturer).ToList();
                    }
                }
                if (medicineDosage != null && medicineDosage != "")
                {
                    if (medicines.Count != 0)
                    {
                        medicines = medicines.Where(k => k.MedicineDosage == medicineDosage).ToList();
                    }
                    else
                    {
                        medicines = db.Medicines.Where(k => k.MedicineDosage == medicineDosage).ToList();
                    }
                }
            }
            return medicines;
        }

        public static Medicine FindMedicineById(int id)
        {
            Medicine medicine = null;
            using (Context db = new Context())
            {
                medicine = db.Medicines.Where(k => k.MedicineID == id).ToList().FirstOrDefault();
            }
            return medicine;
        }
    }
}
