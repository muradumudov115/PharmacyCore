

using Entities.Interfaces;

namespace Entities.Models
{
   public  class MedicalName:IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
