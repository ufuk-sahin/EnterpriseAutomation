using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Concrete.Company
{
    public class Union
    {
        public int UnionId { get; set; }                    //Sendika id
        public string UnionName { get; set; }               //Sendika adi
        public string UnionIdentityId { get; set; }         //Sendika No
        public string UnionDescription { get; set; }        //Sendika tanimi
        public string UnionComment { get; set; }            //Sendika aciklama
    }
}
