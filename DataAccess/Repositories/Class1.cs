using DataAccess.Interface;
using Entities.Interfaces;
using System;
using System.Collections.Generic;


namespace DataAccess.Repositories
{
    public class MedicalNameRepository<TMedicalName> : IRepository<TMedicineName>
        where TMedicalName : IEntity

    {
        public bool Create(TMedicineName entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TMedicalName entity)
        {
            throw new NotImplementedException();
        }

        public TMedicalName Get(Predicate<TMedicalName> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<TMedicalName> GetAll(Predicate<TMedicalName> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(TMedicalName entity)
        {
            throw new NotImplementedException();
        }
    }
}
