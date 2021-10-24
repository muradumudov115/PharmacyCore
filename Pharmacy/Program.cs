using DrugStoreApp.Controller;
using System;
using Utilities.Helpers;

namespace Pharmacy
{
    class Program
    {
        static void Main(string[] args)
        {
            DrugStoreController drugstoreController = new DrugStoreController();
            DrugController drugController = new DrugController();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Welcome");
            while (true)
            {
                ShowMenu();
                string selectedMenu = Console.ReadLine();
                int menu;
                bool isTrue = int.TryParse(selectedMenu, out menu);
                if (isTrue && menu >= 1 && menu <= 9)
                {
                    switch (menu)
                    {
                        case (int)Helper.Menu.CreateDrugStore:
                            drugstoreController.Create();
                            break;
                        case (int)Helper.Menu.UpdateDrugStore:
                            drugstoreController.Update();
                            break;
                        case (int)Helper.Menu.DeleteDrugStore:
                            drugstoreController.Delete();
                            break;
                        case (int)Helper.Menu.GetDrugStoreWithId:
                            break;
                        case (int)Helper.Menu.GetDrugStoreWithName:
                            break;
                        case (int)Helper.Menu.GetAllDrugStore:
                           drugstoreController.GetAll();
                            break;
                        case (int)Helper.Menu.GetDrugStoresWithSize:
                            drugstoreController.GetDrugStoresWithSize();
                            break;
                        case (int)Helper.Menu.CreateDrug:
                            drugstoreController.GetAll();
                            drugController.Create();
                            break;
                        case (int)Helper.Menu.GetAllDrugWithDrugStore:
                            drugstoreController.GetAll();
                            drugController.GetAllDrugWithDrugStore();
                            break;
                    }
                }
                else if (menu == 0)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkCyan, "Bye Bye");
                    break;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Please, select correct option");
                }
            }
        }

        static void ShowMenu()
        {
            Helper.ChangeTextColor(ConsoleColor.Green,
                    "1-Create DrugStore, 2-Update DrugStore, 3-Delete DrugStore, 4-Get DrugStore with Id," +
                    "5-Get DrugStore with Name, 6-All DrugStore, 7-Get DrugStores with size,8-Create Drug,0-Exit");
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Select Option Number:");
        }





    }

    }




}


    
       
       
            

