using SampleApp1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SampleApp1.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        #region Properties
        private List<Professional> _professionals;
        private Professional _selectedProfessional;
        private bool _isRefreshing;
        public ICommand RefreshCommand { get; set; }
        #endregion
        public MainPageViewModel()
        {
            // Initialize list data
            InitializeData();
            // Initialize command for refresh
            RefreshCommand = new Command(CmdRefresh);
        }

        private async void InitializeData()
        {
            Professionals = await DummyProfessionalData.GetProfessionals();
        }

        #region Data get set
        public List<Professional> Professionals
        {
            get
            {
                return _professionals;
            }
            set
            {
                _professionals = value;
                OnPropertyChanged(nameof(Professionals));
            }
        }
        public Professional SelectedProfesstional
        {
            get
            {
                return _selectedProfessional;
            }
            set
            {
                _selectedProfessional = value;
                OnPropertyChanged(nameof(SelectedProfesstional));
            }
        }
        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }
        #endregion
        private async void CmdRefresh()
        {
            IsRefreshing = true;
            await Task.Delay(3000);
            IsRefreshing = false;
        }

        #region Property change event
        public event PropertyChangedEventHandler PropertyChanged;
  
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
        #endregion
    }
}
