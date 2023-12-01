using CoreData;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using mycustomerloginapp.Services;
using mycustomerloginapp.ViewModels;
using mycustomerloginapp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace mycustomerloginapp.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableObject]
        public bool _isBusy;
        [ObservableObject]
        public required string _title;
        [ObservableObject]
        private required string _username;
        [ObservableObject]
        private required string _password;
    }
}
