using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Concrete.Employee
{
    public class Employee
    {
        public int EmployeeId { get; set; }                      //Calisan id
        public string EmployeeFirstName { get; set; }           //Ad
        public string EmployeeLastName { get; set; }            //Soyad
        public int CompanyIdentityNo { get; set; }       //Sicil No
        public string CompanyStatus { get; set; }        //Pozisyonu
        public DateTime DateOfStart { get; set; }        //ise baslama tarihi
        public string DrivinLicenseClass { get; set; }   //Surucu belgesi sinifi B-E-G

        public string CompanySeniorityNo { get; set; }          //Kıdem
        public string CompanyDegreeNo { get; set; }             //Derece

        public int CitizenshipNo { get; set; }          // TC NO
        public string Gender { get; set; }              //Cinsiyet
        public DateTime DateOfBirth { get; set; }       //Dogum tarihi

        public string Adress { get; set; }                          //Adres
        public string City { get; set; }                            //il
        public string Town { get; set; }                            //ilce
        public string County { get; set; }                          //ulke

        public string Birthplace { get; set; }              //dogum yeri
        public string CityOfRegistration { get; set; }              //nufusa kayitli oldugu il
        public string CountyOfRegistration { get; set; }            //nufusa kayitli oldugu ilce
        public string PhoneNumber { get; set; }                     //Telefon no

        public string Description { get; set; }                     //calisan tanimi
        public string Comment { get; set; }                         //calisan aciklama
        public int DayOffNumber { get; set; }                       //kalan izin gunu sayisi

        public string UnionName { get; set; }                       //Sendika adi
        public string UnionIdentityNo { get; set; }                 //Sendika kimlik no
        public int Wage { get; set; }                               //Ucret yevmiye

        public int MaritalStatus { get; set; }                      //Medeni durumu
        public int NumberOfChildren { get; set; }                   //Cocuk Sayisi
        public int PartnerWorkingStatus { get; set; }               //Esinin calisma durumu
    }
}
