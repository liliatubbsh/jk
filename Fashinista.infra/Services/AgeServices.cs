using Fashinista.core.Data;
using Fashinista.core.Repository;
using Fashinista.core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.infra.Services
{
  public  class AgeServices: IAgeServices
    {
        private readonly IAgeRepository ageRepository;
        public AgeServices(IAgeRepository ageRepository)
        {
            this.ageRepository = ageRepository;
        }

        public bool Delete_Age(int id)
        {
            return ageRepository.Delete_Age(id);
        }

        public Age Get_Age_By_Id(int id)
        {
            return ageRepository.Get_Age_By_Id(id);
        }

        public List<Age> GET_All_Age()
        {
            return ageRepository.GET_All_Age();
        }

        public string Insert_Age(Age age)
        {
            return ageRepository.Insert_Age(age);
        }

        public bool Update_Age(Age age)
        {
            return ageRepository.Update_Age(age);
        }
    }
}
