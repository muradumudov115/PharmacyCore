using DataAccess.Interface;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{


    public class DrugStoreRepository : IRepository<DrugStore>
    {
        public bool Create(DrugStore entity)
        {
            try
            {
                DbContext.DrugStores.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(DrugStore entity)
        {

            try
            {
                DbContext.DrugStores.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DrugStore Get(Predicate<DrugStore> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<DrugStore> GetAll(Predicate<DrugStore> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(DrugStore  entity, DrugStore druNew)
        {
            try
            {
                DrugStore dbDrugStore = Get(m => m.Id == entity.Id);
                dbDrugStore.Name = druNew.Name;

                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(DrugStore entity)
        {
            throw new NotImplementedException();
        }
    } }
