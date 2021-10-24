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
        
    }
    

       
}