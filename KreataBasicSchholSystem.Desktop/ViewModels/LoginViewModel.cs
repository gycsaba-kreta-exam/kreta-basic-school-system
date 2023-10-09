using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Security;
using System.Security.Principal;
using System.Threading;

namespace KreataBasicSchholSystem.Desktop.ViewModels
{
    partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        private string _username=string.Empty;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        private SecureString _password=new SecureString();

        [ObservableProperty]
        private string _errorMessage=string.Empty;
        [ObservableProperty]
        private bool _isViewVisible = true;

        [RelayCommand(CanExecute = nameof(IsUsernameAndPasswordValid))]
        private void Login()
        {
            var isValidUser = false;
            if (isValidUser)
            {
                Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(Username), null);
                IsViewVisible = false;
            }
            else
            {
                ErrorMessage = "* Invalid username or password";
            }
        }

        private bool IsUsernameAndPasswordValid()
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(Username) || Username.Length < 3 ||
                Password == null || Password.Length < 3)
                validData = false;
            else
                validData = true;
            return validData;
        }
    }
}
