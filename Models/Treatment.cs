using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Models
{
    public class Treatment
    {
        [Key]
        public int TreatmentID { get; set; }
        public string TreatmentDisease { get; set; }
        public string TreatmentMedication { get; set; }
        public string TreatmentDate { get; set; }
        public string TreatmentDosage { get; set; }
        public string TreatmentDurationOfTreatment { get; set; }
        public int? diseaseID { get; set; }
        public int? medicineID { get; set; }
        public virtual Disease Disease { get; set; }
        public virtual Medicine Medicine { get; set; }

        public Treatment() { }

        public Treatment(int TreatmentID, string TreatmentDisease, string TreatmentMedication, string TreatmentDate, string TreatmentDosage,
             string TreatmentDurationOfTreatment, int? diseaseID, int? medicineID)
        {
            this.TreatmentID = TreatmentID;
            this.TreatmentDisease = TreatmentDisease;
            this.TreatmentMedication = TreatmentMedication;
            this.TreatmentDate = TreatmentDate;
            this.TreatmentDosage = TreatmentDosage;
            this.TreatmentDurationOfTreatment = TreatmentDurationOfTreatment;
            this.diseaseID = diseaseID;
            this.medicineID = medicineID;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Treatment;

            if (obj == null)
            {
                return false;
            }
            if (obj == this)
            {
                return true;
            }

            return this.TreatmentID == item.TreatmentID;
        }

        public override int GetHashCode()
        {
            return this.TreatmentID.GetHashCode();
        }
    }
}
