using kpz_2.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace kpz_2
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<Customer> Customers { get;  set; }
        [DataMember]
        public IEnumerable<Jewelry> JewelryList { get; set; }
        [DataMember]
        public IEnumerable<Order> Orders { get; set; }

        public DataModel()
        {
            Customers = new List<Customer>() { new Customer() { Id = 1, Name = "Pffffetro", Phone = "09525" } };
            JewelryList = new List<Jewelry>() { new Jewelry(){ Id = 1, Name = "Diamond Ring", Price = 100} };
            Orders = new List<Order>() { new Order() { Id = 5, Customer_id = 1, Jewelry_id = 1 } };
        }
        public static string DataPath = "organizer.dat";

        public static DataModel Load()
        {
            if (File.Exists(DataPath))
            {
                return DataSerializer.DeserializeItem(DataPath);
            }
            return new DataModel();
        }
        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }

    }
}
