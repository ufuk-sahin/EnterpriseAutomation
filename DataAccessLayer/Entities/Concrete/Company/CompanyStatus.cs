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
        public string CompanyStatusNo { get; set; }         //Kurum Pozisyon Kodu
        public string CompanyDescription { get; set; }      //Kurum tanimi
        public string CompanyComment { get; set; }          //Kurum aciklama
    }
}
