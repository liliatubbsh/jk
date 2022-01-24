using Fashinista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashinista.core.Services
{
    public interface IColorServices
    {
        public string Insert_Color(Color color);
        public bool Delete_Color_By_Id(int id);
        public bool Update_Color(Color color);
        public List<Color> GET_All_Color();
        public Color Get_Color_By_Id(int id);
    }
}
