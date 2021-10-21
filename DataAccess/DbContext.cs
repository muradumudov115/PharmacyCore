using Entities.Models;
using System.Collections.Generic;


namespace DataAccess
{
  public static   class DbContext
    {
        public static List<MedicalName> MedicalNames { get; set; }
        public static List<MedicalCategory> MedicalCategory { get; }
        public static  List<MedicalCategory> MedicalCatagories { get; set; }

        static DbContext()
        {
            MedicalNames = new List<MedicalName>();
            MedicalCategory = new List<MedicalCategory>();
        }

    }

}
