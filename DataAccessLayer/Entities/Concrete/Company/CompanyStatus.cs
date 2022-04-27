using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Concrete.Company
{
    public class CompanyStatus
    {
        public int CompanyStatusId { get; set; }            //Kurum Pozisyon id
        public string CompanyStatusName { get; set; }       //Kurum Pozisyon Adi
        public string No { get; set; }                      //Kurum Pozisyon Kodu
        public string Description { get; set; }             //Kurum tanimi
        public string Comment { get; set; }                 //Kurum aciklama
    }
}
