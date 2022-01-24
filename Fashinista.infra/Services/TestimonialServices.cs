using Fashinista.core.Data;
using Fashinista.core.DTO;
using Fashinista.core.Repository;
using Fashinista.core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.infra.Services
{
    public class TestimonialServices : ITestimonialServices
    {
        private readonly ITestimonialRepository testimonialRepository;
        public TestimonialServices(ITestimonialRepository testimonialRepository)
        {
            this.testimonialRepository = testimonialRepository;
        }

        public bool Delete_Testimonial_By_Id(int id)
        {
            return testimonialRepository.Delete_Testimonial_By_Id(id);
        }

        public List<Testimonial_Dto> GET_All_Testimonial_Admin()
        {
            return testimonialRepository.GET_All_Testimonial_Admin();
        }

        public List<Testimonial_Dto> GET_All_Testimonial__User()
        {
            return testimonialRepository.GET_All_Testimonial__User();
        }

        public Testimonial Get_Testimonial_By_Id(int id)
        {
            return testimonialRepository.Get_Testimonial_By_Id(id);
        }

        public string Insert_Testimonial(Testimonial testimonial)
        {
            return testimonialRepository.Insert_Testimonial(testimonial);
        }

        public bool Update_Testimonial(Testimonial testimonial)
        {
            return testimonialRepository.Update_Testimonial(testimonial);
        }
    }
}
