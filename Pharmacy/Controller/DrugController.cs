using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Helpers;

namespace DrugStoreApp.Controller
{
    public class DrugController
    {
        public DrugService drugService { get; }
        public DrugController()
        {
            drugService = new DrugService();
        }
        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Select possible drugstore:");
            string drugstoreName = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter drug name:");
            string name = Console.ReadLine();
            Drug drug = new Drug { Name = name, };
            Drug newDrug = drugService.Create(drug, drugstoreName);
            if (newDrug != null)
            {
                Helper.ChangeTextColor(ConsoleColor.Green,
                    $"New Drug is Created - {newDrug.Name}");
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red,
                $"Couldn't find such as DrugStore - {drugstoreName}");
        }
        public void GetAllStudentWithDrugStore()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Select possible drugstore:");
            string drugstoreName = Console.ReadLine();
            List<Drug> drugs = drugService.GetAll(drugstoreName);
            if (drugs != null)
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"DrugStore {drugstoreName}:");
                foreach (var item in drugs)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green,
                    $"{item.Id} - {item.Name}");
                }
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red,
                $"Couldn't find such as DrugStore - {drugstoreName}");
        }
    }
}
