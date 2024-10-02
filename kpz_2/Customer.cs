using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace kpz_2
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id { set; get; }
        [DataMember]
        public String Name { set; get; }
        [DataMember]
        public String Phone { set; get; }
    }
}
