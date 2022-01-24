﻿using Fashinista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.core.Repository
{
   public interface IOfferRepository
    {
        public string Insert_Offer(Offer offer);
        public bool Delete_Offer_By_Id(int id);
        public bool Update_Offer(Offer offer);
        public List<Offer> GET_All_Offer();
        public Offer Get_Offer_By_Id(int id);
    }
}
