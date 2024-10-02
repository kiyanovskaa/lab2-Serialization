using kpz_2;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UI.ViewModels;
using AutoMapper;
using UI.Base;

namespace UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DataModel _model;
        private DataViewModel _viewModel;
        public App()
        {
            
            MapperConfiguration config = new MapperConfiguration(cfg =>
              {
                  cfg.AddProfile<Mapping>();
              });
            IMapper mapper = config.CreateMapper();
            _model = DataModel.Load();
            _viewModel = mapper.Map<DataModel, DataViewModel>(_model);
            var window = new MainWindow() { DataContext = _viewModel };
            window.Show();
        }
        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                MapperConfiguration config = new MapperConfiguration(cfg =>
                  {
                      cfg.AddProfile<Mapping>();
                  });
                IMapper mapper = config.CreateMapper();
                _model = mapper.Map<DataViewModel, DataModel>(_viewModel);
                _model.Save();
            }
            catch (Exception)
            {
                base.OnExit(e);
                throw;
            }
        }
    }
}
