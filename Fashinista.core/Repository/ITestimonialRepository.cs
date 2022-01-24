using Fashinista.core.Data;
using Fashinista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.core.Repository
{
   public interface ITestimonialRepository
    {
        public string Insert_Testimonial(Testimonial testimonial);
        public bool Delete_Testimonial_By_Id(int id);
        public bool Update_Testimonial(Testimonial testimonial);
        public List<Testimonial_Dto> GET_All_Testimonial_Admin();
        public List<Testimonial_Dto> GET_All_Testimonial__User();
        public Testimonial Get_Testimonial_By_Id(int id);
    }
}
