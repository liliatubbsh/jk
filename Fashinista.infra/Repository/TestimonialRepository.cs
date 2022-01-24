using Dapper;
using Fashinista.core.common;
using Fashinista.core.Data;
using Fashinista.core.DTO;
using Fashinista.core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Fashinista.infra.Repository
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly IdbContext context;
        public TestimonialRepository(IdbContext context)
        {
            this.context = context;
        }
        public bool Delete_Testimonial_By_Id(int id)
        {

            var p = new DynamicParameters();
            p.Add("T_ID ", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var item = context.connection.ExecuteAsync("TESTIMONIALS_PACKAGE.DELETETESTIMONIALS", p, commandType: CommandType.StoredProcedure);
            return true;

        }

        public List<Testimonial_Dto> GET_All_Testimonial_Admin()
        {
            IEnumerable<Testimonial_Dto> result = context.connection.Query<Testimonial_Dto>("TESTIMONIALS_PACKAGE.GETALLTESTIMONIALS_Admin", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Testimonial_Dto> GET_All_Testimonial__User()
        {
            IEnumerable<Testimonial_Dto> result = context.connection.Query<Testimonial_Dto>("TESTIMONIALS_PACKAGE.GETALLTESTIMONIALS_User", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Testimonial Get_Testimonial_By_Id(int id)
        {
            var p = new DynamicParameters();
            p.Add("T_ID ", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = context.connection.Query<Testimonial>("TESTIMONIALS_PACKAGE.GETTESTIMONIALSBYID ", p, commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        public string Insert_Testimonial(Testimonial testimonial)
        {
            var p = new DynamicParameters();
            p.Add("T_TEXET ", testimonial.Texet, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("T_STATUS ", testimonial.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("T_CUSTOMER_ID ", testimonial.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.ExecuteAsync("TESTIMONIALS_PACKAGE.INSERTTESTIMONIALS", p, commandType: CommandType.StoredProcedure);
            return "valid";

        }

        public bool Update_Testimonial(Testimonial testimonial)
        {
            var p = new DynamicParameters();
            p.Add("T_TEXET ", testimonial.Texet, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("T_STATUS ", testimonial.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("T_CUSTOMER_ID ", testimonial.CustomerId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = context.connection.ExecuteAsync("TESTIMONIALS_PACKAGE.UPDATETESTIMONIALS", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
