

using Entities.Interfaces;

namespace Entities.Models
{
   public  class Drug:IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
      
        public DrugStore drugstore { get; set; }

    }
}
