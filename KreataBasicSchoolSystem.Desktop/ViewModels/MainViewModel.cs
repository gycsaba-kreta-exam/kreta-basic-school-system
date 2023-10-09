using CommunityToolkit.Mvvm.ComponentModel;
using KreataBasicSchoolSystem.Desktop.Models;
using KreataBasicSchoolSystem.Desktop.Repositories;
using System;
using System.Threading;

namespace KreataBasicSchoolSystem.Desktop.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private UserRepository _userRepository = new();

        [ObservableProperty]
        private UserAccount _currentUser=new();

        public MainViewModel()
        {
            LoadCurrentUserData();
        }

        private void LoadCurrentUserData()
        {
            if (Thread.CurrentPrincipal is not null && Thread.CurrentPrincipal.Identity is not null && Thread.CurrentPrincipal.Identity.Name is not null)
            {
                User? user=_userRepository.GetByUsername(Thread.CurrentPrincipal.Identity.Name);

                if (user is not null)
                {
                    CurrentUser.Username = user.Username;
                    CurrentUser.DisplayName = user.HungarianFullName;
                }
                else
                {
                    CurrentUser.DisplayName = "Hibás felhaszálói név! A bejelentkezés nem sikerült!";
                }
            }
        }
    }
}
