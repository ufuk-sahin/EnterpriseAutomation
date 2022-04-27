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
        public string IdentityId { get; set; }              //Sendika No
        public string Description { get; set; }             //Sendika tanimi
        public string Comment { get; set; }                 //Sendika aciklama
    }
}
