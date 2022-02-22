using HandyControl.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace IcyStorageClient.ViewModels
{
    public class ChromeViewModel : ObservableObject
    {
        private MainViewModel _main;
        public MainViewModel Main
        {
            get => _main;
            set { SetProperty(ref _main, value); }
        }


        private OverlayViewModel _overlay;
        public OverlayViewModel Overlay
        {
            get => _overlay;
            set { SetProperty(ref _overlay, value); }
        }
    }
}
