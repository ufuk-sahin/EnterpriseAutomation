using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Concrete.Vehicle
{
    public class Vehicle
    {
        public int VehicleId { get; set; }                              //Arac id
        public string VehicleName { get; set; }            //Arac adi
        public string CompanyIdentityNo { get; set; }            //Sirket kodu TCK NO
        public string LicencePlate { get; set; }                 //Arac Plaka
        public string Brand { get; set; }                        //Arac Marka 
        public string Model { get; set; }                        //Arac Model
        public string LastInspectionDate { get; set; }           //Arac son muayene tarihi
        public DateTime DateOfStart { get; set; }                //Arac ise baslama tarihi
        public string Description { get; set; }                  //Arac tanimi
        public string Comment { get; set; }                      //Arac aciklama
        public DateTime LastMaintenanceDate { get; set; }        //Son bakim tarihi
        public DateTime NextMaintenanceDate { get; set; }        //Bir sonraki bakim tarihi
    }
}

