using DataAccess.Interface;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
   public  class MedicalCategoryRepository:IRepository<MedicalCategory>
    {
        public bool Create(MedicalCategory entity)
        {
            try
            {
                DbContext.MedicalCategorys.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(MedicalCategory entity)
        {
            try
            {
                DbContext.MedicalCategorys.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public MedicalCategory Get(Predicate<MedicalCategory> filter = null)
        {
            try
            {
                return filter == null ? DbContext.MedicalCategorys[0] :
                    DbContext.MedicalCategorys.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<MedicalCategory> GetAll(Predicate<MedicalCategory> filter = null)
        {
            try
            {
                return filter == null ? DbContext.MedicalCategorys :
                   DbContext.MedicalCategorys.FindAll(filter);


            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(MedicalCategory entity)
        {
            try
            {
                MedicalCategory dbMedicalCategory = Get(s => s.Id == entity.Id);
                dbMedicalCategory.Name = entity.Name;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
