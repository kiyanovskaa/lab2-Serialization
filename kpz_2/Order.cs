using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace kpz_2
{
    [DataContract]
    public enum OrderStatus{
        [EnumMember]
        NEW,
        [EnumMember]
        PROCESSING,
        [EnumMember]
        SHIPPED,
        [EnumMember]
        DELIVERED
    }
    [DataContract]
    public class Order
    {
        [DataMember]
        public int Id { set; get; }
        [DataMember]
        public OrderStatus Status { get; set; }
        [DataMember]
        public int Customer_id { set; get; }
        [DataMember]
        public int Jewelry_id { set; get; }


    }
}
