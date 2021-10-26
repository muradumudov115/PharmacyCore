using Business.Interface;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Excceptions;

namespace Business.Services
{
  
        public class DrugService : IDrug
        {
            private  DrugRepository drugRepository { get; }
            private  DrugStoreService drugstoreService { get; }
            private  static int count;
            public DrugService()
            {
                drugRepository = new DrugRepository();
                drugstoreService = new DrugStoreService();
            }
            public Drug Create(Drug drug, string drugstoreName)
            {
               
            try
            {
                DrugStore dbDrugStore = drugstoreService.Get(drugstoreName);
                if (dbDrugStore != null)
                {
                    drug.drugstore = dbDrugStore;
                    drug.Id = count;
                    drugRepository.Create(drug);
                    count++;
                    return drug;
                }
                else
                {
                    throw new DrugException("Type is not available");
                }

            }
            catch (DrugException ex)
            {

                Console.WriteLine("Type is not available",ex.Message);
                return default;
            }
                
            }
            public List<Drug> GetAll(string drugstoreName)
            {
            try
               
            {
                DrugStore dbDrugStore = drugstoreService.Get(drugstoreName);
                if (dbDrugStore != null)
                {
                    return drugRepository.GetAll(s => s.drugstore.Name == dbDrugStore.Name);
                }
                else
                {
                    throw new DrugException("Type is not available");
                }
            }
            catch (DrugException ex)
            {

                Console.WriteLine("Type is not available",ex.Message);
                return default;
            }
            
                
        }

            public Drug  Delete(int id)
            {
                throw new NotImplementedException();
            }

            public Drug Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Drug> Get(string name)
            {
                throw new NotImplementedException();
            }



            public List<Drug> GetAll()
            {
                throw new NotImplementedException();
            }

            public Drug Update(Drug drug, string drugstoreName)
            {
                throw new NotImplementedException();
            }
        }
    }
