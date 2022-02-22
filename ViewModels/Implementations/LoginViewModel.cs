using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IcyStorageClient.Services;
using HandyControl.Tools;
using Microsoft.Toolkit.Mvvm;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.Input;

namespace IcyStorageClient.ViewModels
{
    public class LoginViewModel : ObservableObject
    {
        private readonly ILoginService _loginService;

        public LoginViewModel(ILoginService loginService)
        {
            _loginService = loginService;

            LoginCommand = new AsyncRelayCommand(LoginAsync);
        }

        private string _email;
        public string Email
        {
            get => _email;
            set { SetProperty(ref _email, value); }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set { SetProperty(ref _password, value); }
        }

        public IAsyncRelayCommand LoginCommand { get; }

        private async Task LoginAsync()
        {

        }

    }
}
