using Fashinista.core.Data;
using Fashinista.core.Repository;
using Fashinista.core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.infra.Services
{
    public class ColorServices : IColorServices
    {

        private readonly IColorRepository colorRepository;
        public ColorServices(IColorRepository colorRepository)
        {
            this.colorRepository = colorRepository;
        }

        public bool Delete_Color_By_Id(int id)
        {
            return colorRepository.Delete_Color_By_Id(id);
        }

        public List<Color> GET_All_Color()
        {
            return colorRepository.GET_All_Color();
        }

        public Color Get_Color_By_Id(int id)
        {
            return colorRepository.Get_Color_By_Id(id);
        }

        public string Insert_Color(Color color)
        {
            return colorRepository.Insert_Color(color);
        }

        public bool Update_Color(Color color)
        {
            return colorRepository.Update_Color(color);
        }
    }
}
