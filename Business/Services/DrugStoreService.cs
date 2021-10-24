

using Business.Interface;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;

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
            catch (Exception)
            {

                return null;
            }
            
        }

      public DrugStore Update(int Id, Drug drug)
        {
            throw new NotImplementedException();
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

        public DrugStore Create(Drug drug)
        {
            throw new NotImplementedException();
        }
    }
}
