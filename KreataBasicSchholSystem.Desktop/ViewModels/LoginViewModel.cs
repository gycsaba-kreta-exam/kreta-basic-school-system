using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Security;
using System.Windows.Navigation;

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

        [RelayCommand(CanExecute = nameof(IsUsernameAndPasswordValid))]
        private void Login()
        {

        }

        private bool IsUsernameAndPasswordValid()
        {
            return true;
        }
    }
}
