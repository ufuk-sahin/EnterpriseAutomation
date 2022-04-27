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
        public string Title { get; set; }                    //Firma Fatura Basligi
        public string IdentityNo { get; set; }               //Firma No
        public string IBN { get; set; }                      //IBN no
        public string TaxNumber { get; set; }                //Vergi No
        public string TaxOffice { get; set; }                //Veri dairesi
        public string SGKNo { get; set; }                    //SGK no

        public string Adress { get; set; }                   //Adres
        public string City { get; set; }                     //il
        public string Town { get; set; }                   //ilce
        public string County { get; set; }                   //ulke
        public string PhoneNumber1 { get; set; }             //Telefon1
        public string PhoneNumber2 { get; set; }             //Telefon2
        public string PhoneNumber3 { get; set; }             //Telefon3
        public string Description { get; set; }              //Firma tanim
        public string Comment { get; set; }                  //Firma aciklama
    }
}
