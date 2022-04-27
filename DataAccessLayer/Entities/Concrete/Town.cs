using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Concrete
{
    public class Town
    {
        public int TownId { get; set; }               //kasaba id
        public string TownName { get; set; }          //kasaba adi
        public int PostCode { get; set; }         //kasaba posta kodu

    }
}
