using Entities.Models;
using System;
using System.Collections.Generic;


namespace DataAccess
{
  public static   class DbContext
    {
        public static List<MedicalName> MedicalNames { get; }
        public static List<MedicalCategory> MedicalCategorys { get; }
        static DbContext()
        {
            MedicalNames = new List<MedicalName>();
            MedicalCategorys = new List<MedicalCategory>();

        }

        

        
    }

}
