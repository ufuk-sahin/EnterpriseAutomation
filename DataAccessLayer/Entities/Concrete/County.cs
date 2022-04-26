using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Concrete
{
    public class County
    {
        public int CountyId { get; set; }               //ulke id
        public string CountyName { get; set; }          //ulke adi
        public int CountyPhoneCode { get; set; }        //ulke plaka kodu
        public int CountyPostCode { get; set; }         //ulke posta kodu
    }
}
