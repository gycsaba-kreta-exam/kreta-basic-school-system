using CommunityToolkit.Mvvm.ComponentModel;
using System.Security;

namespace KreataBasicSchholSystem.Desktop.ViewModels
{
    partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _username;
        [ObservableProperty]
        private SecureString _password;

        [ObservableProperty]
        private string _errorMessage;
        [ObservableProperty]
        private bool _isViewVisible = true;
    }
}
