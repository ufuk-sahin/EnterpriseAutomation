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
        public int PhoneCode { get; set; }        //ulke plaka kodu
        public int PostCode { get; set; }         //ulke posta kodu
    }
}
