using DataAccess.Interface;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class DrugRepository : IRepository<Drug>
    {
        public bool Create(Drug entity)
        {
            try
            {
                DbContext.Drugs.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Drug entity)
        {
            try
            {
                DbContext.Drugs.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Drug Get(Predicate<Drug> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Drug> GetAll(Predicate<Drug> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Drug entity)
        {
            throw new NotImplementedException();
        }

    }
   
}   
    
        
     
       
           
