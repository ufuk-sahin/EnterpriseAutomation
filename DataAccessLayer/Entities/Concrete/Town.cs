using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Concrete
{
    public class Town
    {
        public int CountyId { get; set; }               //kasaba id
        public string CountyName { get; set; }          //kasaba adi
        public int CountyPostCode { get; set; }         //kasaba posta kodu

    }
}
