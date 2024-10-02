using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.ViewModels
{
    public class CustomerViewModel:ViewModelBase
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
        private String _name;
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        private int _phone;
        public int Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
                OnPropertyChanged("Phone");
            }
        }
    }
    public class CustomerEqualityComparer : IEqualityComparer<CustomerViewModel>
    {
        public bool Equals(CustomerViewModel x, CustomerViewModel y)
        {
            return x.Id == y.Id
                && x.Name == y.Name
                && x.Phone == y.Phone;
        }

        public int GetHashCode(CustomerViewModel obj)
        {
            throw new NotImplementedException();
        }


    }
}
