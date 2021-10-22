using DataAccess.Interface;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class MedicalNameRepository : IRepository<MedicalName>
       

    {
        public bool Create(MedicalName entity)
        {
            try
            {
                DbContext.MedicalNames.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(MedicalName entity)
        {
            try
            {
                DbContext.MedicalNames.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public MedicalName Get(Predicate<MedicalName> filter = null)
        {
            try
            {
                return filter == null ? DbContext.MedicalNames[0] :
                    DbContext.MedicalNames.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }  
        }

        public List<MedicalName> GetAll(Predicate<MedicalName> filter = null)
        {
            try
            {
                return filter == null ? DbContext.MedicalNames :
                   DbContext.MedicalNames.FindAll(filter);


            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(MedicalName entity)
        {
            try
            {
                MedicalName dbMedicalName = Get(s => s.Id == entity.Id);
               dbMedicalName=entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
