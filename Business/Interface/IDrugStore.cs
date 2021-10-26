using Entities.Models;
using System.Collections.Generic;

namespace Business.Interface
{
    public  interface IDrugStore
    {
        DrugStore Create(DrugStore drug);
        DrugStore Update(int Id, DrugStore drug);
        DrugStore Delete(int Id);
        DrugStore Get(string Name);
        List<DrugStore> GetAll();
 
    }
}
