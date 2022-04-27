using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Concrete.Device
{
    public class DeviceModel
    {
        public int DeviceModelId { get; set; }                  //Cihaz Model id
        public string DeviceModelName { get; set; }             //Cihaz Model adi
        public string Description { get; set; }      //Cihaz Model tanim
        public string Comment { get; set; }          //Cihaz Model aciklama
    }
}
