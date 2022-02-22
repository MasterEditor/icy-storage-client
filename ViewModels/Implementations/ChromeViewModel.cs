﻿using HandyControl.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcyStorageClient.ViewModels
{
    public class ChromeViewModel : BindablePropertyBase, IViewModel
    {
        private MainViewModel _main;
        public MainViewModel Main
        {
            get => _main;
            set { Set(ref _main, value); }
        }


        private OverlayViewModel _overlay;
        public OverlayViewModel Overlay
        {
            get => _overlay;
            set { Set(ref _overlay, value); }
        }
    }
}
