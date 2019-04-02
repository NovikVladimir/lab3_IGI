using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab3.Models;

namespace lab3.Data
{
    public class TreatmensContext
    {
        public static List<Treatment> GetAll()
        {
            List<Treatment> all = new List<Treatment>();
            using (Context db = new Context())
            {
                all = db.Treatmens.ToList();
            }

            return all;
        }

        public static void AddTreatment(Treatment treatmentToAdd)
        {
            using (Context db = new Context())
            {
                db.Treatmens.Add(treatmentToAdd);
                db.SaveChanges();
            }
        }

        public static void UpdataTreatment(Treatment treatment)
        {
            using (Context db = new Context())
            {
                if (treatment != null)
                {
                    db.Treatmens.Update(treatment);
                    db.SaveChanges();
                }
            }
        }

        public static void DeleteTreatment(Treatment treatmentToDelete)
        {
            using (Context db = new Context())
            {
                if (treatmentToDelete != null)
                {
                    db.Treatmens.Remove(treatmentToDelete);
                    db.SaveChanges();
                }
            }
        }

        public static List<Treatment> FindTreatment(string treatmentDisease, string treatmentMedication)
        {
            List<Treatment> services = new List<Treatment>();
            using (Context db = new Context())
            {
                if (treatmentDisease != null && treatmentDisease != "")
                {
                    services = db.Treatmens.Where(k => k.TreatmentDisease == treatmentDisease).ToList();
                }
                if (treatmentMedication != null)
                {
                    if (services.Count != 0)
                    {
                        services = services.Where(k => k.TreatmentMedication == treatmentMedication).ToList();
                    }
                    else
                    {
                        services = db.Treatmens.Where(k => k.TreatmentMedication == treatmentMedication).ToList();
                    }
                }
            }
            return services;
        }

        public static Treatment FindTreatment(int id)
        {
            Treatment service = null;
            using (Context db = new Context())
            {
                service = db.Treatmens.Where(k => k.TreatmentID == id).ToList().FirstOrDefault();
            }
            return service;
        }
    }
}
