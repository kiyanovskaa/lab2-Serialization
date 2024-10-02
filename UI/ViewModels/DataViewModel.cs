using kpz_2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UI.ViewModels
{
    public class DataViewModel: ViewModelBase
    {
        public DataViewModel()
        {
            CloseOrderCommand = new Command(CloseOrder);
            SetControlVisibility = new Command(ControlVisibility);
            Delete = new Command(DeleteModel);
        }
        private string _visibleControl="Orders";
        public string VisibleControl
        {
            get
            {
                return _visibleControl;
            }
            set
            {
                _visibleControl = value;
                OnPropertyChanged("VisibleControl");

            }
        }

        private OrderViewModel _selectedOrder;
        public OrderViewModel SelectedOrder
        {
            get
            {
                return _selectedOrder;
            }
            set
            {
                _selectedOrder = value;
                OnPropertyChanged("SelectedOrder");

            }
        }
        private CustomerViewModel _selectedCustomer;
        public CustomerViewModel SelectedCustomer
        {
            get
            {
                return _selectedCustomer;
            }
            set
            {
                _selectedCustomer = value;
                OnPropertyChanged("SelectedCustomer");

            }
        }
        private JewelryViewModel _selectedJewelry;
        public JewelryViewModel SelectedJewelry
        {
            get
            {
                return _selectedJewelry;
            }
            set
            {
                _selectedJewelry = value;
                OnPropertyChanged("SelectedJewelry");

            }
        }
        public ICommand SetControlVisibility { get; set; }

        public void ControlVisibility(object args)
        {
            VisibleControl = args.ToString();
        }
        public ICommand CloseOrderCommand { get; set; }

        public void CloseOrder (object args)
        {
            SelectedOrder.Status = OrderStatus.DELIVERED;
        }
         

        private ObservableCollection<CustomerViewModel> _customers;
        public ObservableCollection<CustomerViewModel> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                OnPropertyChanged("Customers");
            }
        }
        private ObservableCollection<JewelryViewModel> _jewelryList;
        public ObservableCollection<JewelryViewModel> JewelryList
        {
            get
            {
                return _jewelryList;
            }
            set
            {
                _jewelryList = value;
                OnPropertyChanged("JewelryList");
            }
        }
        private ObservableCollection<OrderViewModel> _orders;
        public ObservableCollection<OrderViewModel> Orders
        {
            get
            {
                return _orders;
            }
            set
            {
                _orders = value;
                OnPropertyChanged("Orders");
            }
        }

        public ICommand Delete { get; set; }
        public void DeleteModel(object args)
        {
            if (VisibleControl == "Customers")
            {
                if (SelectedCustomer != null)
                {
                    if (Customers.Contains(SelectedCustomer))
                    {
                        Customers.Remove(SelectedCustomer);
                    }
                }
            }
            if (VisibleControl == "Orders")
            {
                if (SelectedOrder != null)
                {
                    if (Orders.Contains(SelectedOrder))
                    {
                        Orders.Remove(SelectedOrder);
                    }
                }
            }
            if (VisibleControl == "JewelryList")
            {
                if (SelectedJewelry != null)
                {
                    if (JewelryList.Contains(SelectedJewelry))
                    {

                        JewelryList.Remove(SelectedJewelry);
                    }
                }
            }
        }
    }
}
