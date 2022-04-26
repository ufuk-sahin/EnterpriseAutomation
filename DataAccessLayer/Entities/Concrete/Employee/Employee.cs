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
        public int EmployeeCompanyIdentityNo { get; set; }       //Sicil No
        public string EmployeeCompanyStatus { get; set; }        //Pozisyonu
        public DateTime EmployeeDateOfStart { get; set; }        //ise baslama tarihi
        public string EmployeeDrivinLicenseClass { get; set; }   //Surucu belgesi sinifi B-E-G

        public string EmployeeCompanySeniorityNo { get; set; }
        public string EmployeeCompanyDegreeNo { get; set; }

        public int EmployeeCitizenshipNo { get; set; }          // TC NO
        public string EemployeeFirstName { get; set; }           //Ad
        public string EmployeeLastName { get; set; }            //Soyad
        public string EmployeeGender { get; set; }              //Cinsiyet
        public DateTime EmployeeDateOfBirth { get; set; }       //Dogum tarihi

        public string EmployeeAdress { get; set; }                          //Adres
        public string EmployeeCity { get; set; }                            //il
        public string EmployeeCounty { get; set; }                          //ilce

        public string EmployeeemployeeBirthplace { get; set; }              //dogum yeri
        public string EmployeeCityOfRegistration { get; set; }              //nufusa kayitli oldugu il
        public string EmployeeCountyOfRegistration { get; set; }            //nufusa kayitli oldugu ilce
        public string EmployeePhoneNumber { get; set; }                     //Telefon no

        public string EmployeeDescription { get; set; }                     //calisan tanimi
        public string EmployeeComment { get; set; }                         //calisan aciklama
        public int EmployeeDayOffNumber { get; set; }                       //kalan izin gunu sayisi

        public string EmployeeUnionName { get; set; }                       //Sendika adi
        public string EmployeeUnionIdentityNo { get; set; }                 //Sendika kimlik no
        public int EmployeeWage { get; set; }                               //Ucret yevmiye

        public int EmployeeMaritalStatus { get; set; }                      //Medeni durumu
        public int EmployeeNumberOfChildren { get; set; }                   //Cocuk Sayisi
        public int EmployeePartnerWorkingStatus { get; set; }               //Esinin calisma durumu
    }
}
