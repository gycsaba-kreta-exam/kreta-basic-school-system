using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FontAwesome.Sharp;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.Views.ControlPanel;

namespace KretaBasicSchoolSystem.Desktop.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private ControlPanelViewModel _controlPanelViewModel;

        [ObservableProperty]
        private string _caption = string.Empty;

        [ObservableProperty]
        private IconChar _icon = new IconChar();

        [ObservableProperty]
        private BaseViewModel _currentChildView;

        public MainViewModel(ControlPanelViewModel controlPanelViewModel)
        {
            _controlPanelViewModel = controlPanelViewModel;
            CurrentChildView = _currentChildView;
            ShowDashbord();
        }

        [RelayCommand]
        public void ShowDashbord()
        {
            Caption = "Vezérlőpult";
            Icon=IconChar.Home;
            CurrentChildView = _controlPanelViewModel;
        }
    }
}
