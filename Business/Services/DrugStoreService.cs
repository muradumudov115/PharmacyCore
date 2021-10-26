

using Business.Interface;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using Utilities.Exceptions;

namespace Business.Services

{
    public class DrugStoreService:IDrugStore 
    {


        public DrugStoreRepository drugstoreRepository { get; set; }
        private static int count { get; set; }
        public  DrugStoreService()
        {
             drugstoreRepository = new DrugStoreRepository();
        }


        public DrugStore Create(DrugStore drugstore)
        {
            try
            {
                drugstore.Id = count;
                DrugStore  isExit = drugstoreRepository.Get(g => g.Name.ToLower() == drugstore.Name.ToLower());
                if (isExit != null)
                drugstoreRepository.Create(drugstore);
                count++;
                return drugstore;
            }
            catch (DrugStoreException ex)
            {
                Console.WriteLine("Type is not available",ex.Message);
                
            }
            
        }

        public DrugStore Update(int Id, DrugStore drugstore)
        {
            try
            {
                DrugStore dbDrugStore = drugstoreRepository.Get(s => s.Id == drugstore.Id);
                if (dbDrugStore != null)
                {
                    drugstoreRepository.Update(dbDrugStore, drugstore);
                    return dbDrugStore;
                }
                else
                {
                    throw new DrugStoreException("Type is not available");
                }
            }
            catch (DrugStoreException ex)
            {

                Console.WriteLine("Type is not available",ex.Message);
            }
        }

        public DrugStore Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public DrugStore Get(string Name)
        {
            throw new NotImplementedException();
        }

        public List<DrugStore> GetAll()
        {
            throw new NotImplementedException();
        }

        

        
    }
}
