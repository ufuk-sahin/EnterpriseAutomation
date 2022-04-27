using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Concrete.Device
{
    public class Device 
    {
        public int DeviceId { get; set; }                           //Cihaz id
        public string DeviceName { get; set; }                      //Cihaz Adi
        public string CompanyIdentityNo { get; set; }         //Cihaz kodu TCKNO BTKNO etc
        public int Brand { get; set; }                        //Cihaz Markasi
        public int Model { get; set; }                        //Cihaz Modeli
        public string Description { get; set; }               //Cihaz Tanim
        public string Comment { get; set; }                   //Cihaz aciklama
    }
}
