using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Concrete.Company
{
    public class Company
    {
        public int CompanyId { get; set; }                          //Firma id
        public string CompanyName { get; set; }                     //Firma Adi
        public string CompanyTitle { get; set; }                    //Firma Fatura Basligi
        public string CompanyIdentityNo { get; set; }               //Firma No
        public string CompanyIBN { get; set; }                      //IBN no
        public string CompanyTaxNumber { get; set; }                //Vergi No
        public string CompanyTaxOffice { get; set; }                //Veri dairesi
        public string CompanySGKNo { get; set; }                    //SGK no

        public string CompanyAdress { get; set; }                   //Adres
        public string CompanyCity { get; set; }                     //il
        public string CompanyCounty { get; set; }                   //ilce
        public string CompanyPhoneNumber1 { get; set; }             //Telefon1
        public string CompanyPhoneNumber2 { get; set; }             //Telefon2
        public string CompanyPhoneNumber3 { get; set; }             //Telefon3
        public string CompanyDescription { get; set; }              //Firma tanim
        public string CompanyComment { get; set; }                  //Firma aciklama
    }
}
