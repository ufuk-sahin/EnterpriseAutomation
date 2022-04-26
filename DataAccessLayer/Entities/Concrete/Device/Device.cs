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
        public string DeviceCompanyIdentityNo { get; set; }         //Cihaz kodu TCKNO BTKNO etc
        public string DeviceName { get; set; }                      //Cihaz Adi
        public int DeviceBrnad { get; set; }                        //Cihaz Markasi
        public int DeviceModel { get; set; }                        //Cihaz Modeli
        public string DeviceDescription { get; set; }               //Cihaz Tanim
        public string DeviceComment { get; set; }                   //Cihaz aciklama
    }
}
