

using Business.Interface;
using DataAccess.Repositories;
using Entities.Models;
using System.Collections.Generic;

namespace Business.Services
{
    public class MedicalCategoryService : IMedicalCategory
    {
        public MedicalCategoryRepository medicalcategoryRepository { get; set; }
        private static int count { get; set; }
        public MedicalCategoryService()
        {
            medicalcategoryRepository = new MedicalCategoryRepository();
        }
      
      
        public IMedicalCategory Create(Interface.MedicalName medicalname)
        {
            try
            {
                medicalname.Id = count;
                MedicalCategory isExist = 
                    medicalcategoryRepository.Get(g => g.Name.ToLower() == medicalcategory.Name.ToLower());

            }
            catch (System.Exception)
            {

                return null; ;
            }
        }

        public IMedicalCategory Delete(int Id)
        {
            throw new System.NotImplementedException();
        }

        public IMedicalCategory Get(string Name)
        {
            throw new System.NotImplementedException();
        }

        public List<MedicalCategory> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IMedicalCategory Update(int Id, Interface.MedicalName medicalname)
        {
            throw new System.NotImplementedException();
        }
    }


}
