using Entities.Models;
using System;
using System.Collections.Generic;


namespace DataAccess
{
  public static   class DbContext
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        
        public static DrugStore DrugStore { get; set; }
        public static List<Drug> Drugs  { get; }
        public static List<DrugStore> DrugStores { get; }
        static DbContext()
        {
            Drugs = new List<Drug>();
            DrugStores = new List<DrugStore>();
        }






    }

}
