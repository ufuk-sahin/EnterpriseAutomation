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
        public string VehicleCompanyIdentityNo { get; set; }            //Sirket kodu TCK NO
        public string VehicleLicencePlate { get; set; }                 //Arac Plaka
        public string VehicleBrand { get; set; }                        //Arac Marka 
        public string VehicleModel { get; set; }                        //Arac Model
        public string VehicleLastInspectionDate { get; set; }           //Arac son muayene tarihi
        public DateTime VehicleDateOfStart { get; set; }                //Arac ise baslama tarihi
        public string VehicleDescription { get; set; }                  //Arac tanimi
        public string VehicleComment { get; set; }                      //Arac aciklama
        public DateTime VehicleLastMaintenanceDate { get; set; }        //Son bakim tarihi
        public DateTime VehicleNextMaintenanceDate { get; set; }        //Bir sonraki bakim tarihi
    }
}

