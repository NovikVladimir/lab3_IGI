using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab3.Models;

namespace lab3.Data
{
    public class DiseasesContext
    {
        public static List<Disease> GetAll()
        {
            List<Disease> all = new List<Disease>();
            using (Context db = new Context())
            {
                all = db.Diseases.ToList();
            }

            return all;
        }

        public static void AddDisease(Disease diseaseToAdd)
        {
            using (Context db = new Context())
            {
                db.Diseases.Add(diseaseToAdd);
                db.SaveChanges();
            }
        }

        public static void UpdataDisease(Disease disease)
        {
            using (Context db = new Context())
            {
                if (disease != null)
                {
                    db.Diseases.Update(disease);
                    db.SaveChanges();
                }
            }
        }

        public static void DeleteDisease(Disease diseaseToDelete)
        {
            using (Context db = new Context())
            {
                if (diseaseToDelete != null)
                {
                    db.Diseases.Remove(diseaseToDelete);
                    db.SaveChanges();
                }
            }
        }

        public static List<Disease> FindDiseases(string diseaseName, string diseaseSymptoms)
        {
            List<Disease> diseases = new List<Disease>();
            using (Context db = new Context())
            {
                if (diseaseName != null && diseaseName != "")
                {
                    diseases = db.Diseases.Where(k => k.DiseaseName == diseaseName).ToList();
                }
                if (diseaseSymptoms != null && diseaseSymptoms != "")
                {
                    if (diseases.Count != 0)
                    {
                        diseases = diseases.Where(k => k.DiseaseSymptoms == diseaseSymptoms).ToList();
                    }
                    else
                    {
                        diseases = db.Diseases.Where(k => k.DiseaseSymptoms == diseaseSymptoms).ToList();
                    }
                }
            }
            return diseases;
        }

        public static Disease FindDiseaseById(int id)
        {
            Disease disease = null;
            using (Context db = new Context())
            {
                disease = db.Diseases.Where(k => k.DiseaseID == id).ToList().FirstOrDefault();
            }
            return disease;
        }
    }
}
