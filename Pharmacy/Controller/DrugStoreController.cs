using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using Utilities.Helpers;

namespace Pharmacy
{
   public class DrugStoreController
    {
        public DrugStoreService  drugStoreService { get; }
        public DrugStoreController()
        {
            drugStoreService = new DrugStoreService();
        }
        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter DrugStore name:");
            string name = Console.ReadLine();
        EnterName: Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter DrugStore max drug");
            string size = Console.ReadLine();
            int MaxSize;
            bool isTrueSize = int.TryParse(size, out MaxSize);
            if (isTrueSize)
            {

                DrugStore drugstore = new DrugStore { Name = name, MaxSize = MaxSize };
                if (drugStoreService.Create(drugstore )!=null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green,$"{drugstore.Name} created");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Something is wrong!!!!");
                    return;
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Enter Correct Size");
                goto EnterName;
            }
        }
        public void GetAll()
        {
            Helper.ChangeTextColor(ConsoleColor.Yellow, "All drugstore:");
            foreach (DrugStore drugStore in drugStoreService.GetAll())
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"{drugStore.Id} - {drugStore.Name }");

            }
            

        }
        public void Update()
        {
            GetAll();
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Enter drugstore Id Which Do you want to Update ");
            string input = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Add A New DrugStore Name ");
            string input1 = Console.ReadLine();
            int Id;
            bool isTrueDrug = int.TryParse(input, out Id);
            
           if (isTrueDrug)
            {
                DrugStore  drugstore  = new DrugStore { Name=str1};
                if (drugstoreServic.Update(Id,drugstore )!=null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Cyan, "Name is Changed");
                    return;

                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Please Enter Correct Format");
                }

            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Please select corect format");
            } drugstore = new DrugStore { Name = str1 };
                if (pharmacyServic.Update(Id, drugstore) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Cyan, "Name is Changed");
                    return;

                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Please Enter Correct Format");
                }

            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Please select corect format");
            }

        }
    

       
}