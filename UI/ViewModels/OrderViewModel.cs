using kpz_2;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.ViewModels
{
    public class OrderViewModel: ViewModelBase
    {
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }
        private int _customer_id;
        public int Customer_id
        {
            get
            {
                return _customer_id;
            }
            set
            {
                _customer_id = value;
                OnPropertyChanged("Customer_id");
            }
        }
        private int _jewelry_id;
        public int Jewelry_id
        {
            get
            {
                return _jewelry_id;
            }
            set
            {
                _jewelry_id = value;
                OnPropertyChanged("Jewelry_id");
            }
        }
        private OrderStatus _status;
        public OrderStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }
    public class OrderEqualityComparer : IEqualityComparer<OrderViewModel>
    {
        public bool Equals(OrderViewModel x, OrderViewModel y)
        {
            return x.Customer_id == y.Customer_id
                && x.Id == y.Id
                && x.Status == y.Status
                && x.Jewelry_id == y.Jewelry_id;
        }

        public int GetHashCode(OrderViewModel obj)
        {
            throw new NotImplementedException();
        }

       
    }
}
