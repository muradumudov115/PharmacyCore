using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Helpers
{
    public static class Helper
    {
        public static void ChangeTextColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public enum Menu
        {
            Exit,
            CreateDrugStore,
            UpdateDrugStore,
            DeleteDrugStore,
            GetDrugStoreWithId,
            GetDrugStoreWithName,
            GetAllDrugStore,
            GetDrugStoresWithSize,
            CreateDrug,
            GetAlldrug

        }
    }
}
