

using Entities.Interfaces;

namespace Entities.Models
{
   public  class DrugStore : IEntity 
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxSize { get; set; }



    }
}
