using Fashinista.core.Data;
using Fashinista.core.Repository;
using Fashinista.core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.infra.Services
{
    public class OfferServices : IOfferServices
    {
         private readonly IOfferRepository OfferRepository;
        public OfferServices(IOfferRepository OfferRepository)
        {
            this.OfferRepository = OfferRepository;
        }
        public bool Delete_Offer_By_Id(int id)
        {
            return OfferRepository.Delete_Offer_By_Id(id);
        }

        public List<Offer> GET_All_Offer()
        {
            return OfferRepository.GET_All_Offer();
        }

        public Offer Get_Offer_By_Id(int id)
        {
            return OfferRepository.Get_Offer_By_Id(id);

        }

        public string Insert_Offer(Offer offer)
        {
            return OfferRepository.Insert_Offer(offer);
        }

        public bool Update_Offer(Offer offer)
        {
            return OfferRepository.Update_Offer(offer);
        }
    }
}
