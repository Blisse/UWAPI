using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using UW.Services;

namespace UW.ViewModels
{
    public class HomePageViewModel: ViewModelBase
    {
        private readonly IUwDataService _uwDataService;

        public HomePageViewModel(IUwDataService uwDataService)
        {
            _uwDataService = uwDataService;
        }
    }
}
