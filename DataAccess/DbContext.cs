using Entities.Models;
using System;
using System.Collections.Generic;


namespace DataAccess
{
  public static   class DbContext
    {
        public static List<MedicalName> MedicalNames { get; set; }
        public static List<MedicalCategory> MedicalCategorys { get; }
        public static  List<MedicalCategory> MedicalCatagories { get; set; }
        public static List<MedicalName> Tnew { get; }
        public static List<MedicalName> T { get; }

        static DbContext()
        {
            MedicalNames = Tnew;
        new List<MedicalName>();
            MedicalCategorys = new List<MedicalCategory>();
        }

        private static void List<T>()
        {
            throw new NotImplementedException();
        }
    }

}
