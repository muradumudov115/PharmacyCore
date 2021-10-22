using Entities.Models;
using System.Collections.Generic;

namespace Business.Interface
{
    public  interface IMedicalCategory
    {
        IMedicalCategory Create(MedicalName medicalname);
        IMedicalCategory Update(int Id, MedicalName medicalname);
        IMedicalCategory Delete(int Id); 
        IMedicalCategory Get(string Name);
        List<MedicalCategory> GetAll();
        




    }
}
