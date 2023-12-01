using mycustomerloginapp;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using mycustomerloginapp.Services;

namespace mycustomerloginapp.ViewModels
{
    public partial class LoginpageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private required string _username;

        [ObservableProperty]
        private required string _password;

        readonly ILoginRespository loginRespository = new LoginService();

        [ICommand]
        public async void Login() 
        {
            if (string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password))
            {
                UserInfo userInfo = await loginRespository.Login(Username, Password);

                if (Preferences.ContainsKey(nameof(AppHelpers.UserInfo)))
                {

                    Preferences.Remove(nameof(AppHelpers.UserInfo));
                }
                string userDetails = JsonConvert.SerializeObject(UserInfo);
                Preferences.Set(nameof(AppHelpers.UserInfo), userDetails);
                AppHelpers.UserInfo = UserInfo;

                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();
                await Shell.Current.GoToAsync($"//{nameof(LoginpageViewModel)}");
            }
        }
    }
}
