using Entities.Models;
using System.Collections.Generic;

namespace Business.Interface
{
    public interface IDrug
    {
        Drug Create(Drug drug, string drugstoreName);
        Drug Delete(int id);
        Drug Update(Drug drug, string drugstoreName);
        Drug Get(int id);
        List<Drug> Get(string name);
        List<Drug> GetAll(string drugstoreName);
        List<Drug> GetAll();
    }
}