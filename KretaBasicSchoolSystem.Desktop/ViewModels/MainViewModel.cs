using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FontAwesome.Sharp;
using KretaBasicSchoolSystem.Desktop.Models;
using KretaBasicSchoolSystem.Desktop.Repositories;
using System.Threading;

namespace KretaBasicSchoolSystem.Desktop.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {      
        [ObservableProperty]
        private string _caption=string.Empty;

        [ObservableProperty]
        private IconChar _icon;

        [ObservableProperty]
        private ObservableObject _currentChildView;

        public MainViewModel()
        {
               ShowDashbord();
        }

        [RelayCommand]
        public void ShowDashbord()
        {
            Caption = "Vezérlőpult";
            Icon=IconChar.Home;
        }
    }
}
