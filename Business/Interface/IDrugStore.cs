using Entities.Models;
using System.Collections.Generic;

namespace Business.Interface
{
    public  interface IDrugStore
    {
        DrugStore Create(Drug drug);
        DrugStore Update(int Id, Drug drug);
        DrugStore Delete(int Id);
        DrugStore Get(string Name);
        List<DrugStore> GetAll();
        




    }
}
