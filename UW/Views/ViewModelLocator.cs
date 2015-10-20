using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using UW.Services;
using UW.ViewModels;

namespace UW.Views
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            if (ViewModelBase.IsInDesignModeStatic)
            {

            }
            else
            {
                SimpleIoc.Default.Register<IUwDataService, UwDataService>();
            }

            SimpleIoc.Default.Register<HomePageViewModel>();
        }

        HomePageViewModel HomePage => SimpleIoc.Default.GetInstance<HomePageViewModel>();
    }
}
