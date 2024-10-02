using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using kpz_2;
using UI.ViewModels;

namespace UI.Base
{
   public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<DataModel, DataViewModel>();
            CreateMap<DataViewModel, DataModel>();

            CreateMap<Order, OrderViewModel>();
            CreateMap<OrderViewModel, Order>();

            CreateMap<Jewelry, JewelryViewModel>();
            CreateMap<JewelryViewModel, Jewelry>();

            CreateMap<Customer, CustomerViewModel>();
            CreateMap<CustomerViewModel, Customer>();
        }

    }
}
