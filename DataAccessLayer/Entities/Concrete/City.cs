using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Concrete
{
    public class City
    {
        public int CityId { get; set; }                 //il id
        public string CityName { get; set; }            //il adi
        public int PlateCode { get; set; }        //il plaka kodu
        public int PostCode { get; set; }           //il posta kodu
    }
}
