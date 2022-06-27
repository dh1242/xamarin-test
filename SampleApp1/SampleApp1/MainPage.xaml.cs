using SampleApp1.Models;
using SampleApp1.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleApp1
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;
        public MainPage()
        {
            vm = new MainPageViewModel();
            InitializeComponent();
            BindingContext = vm;
        }
        private void SearchTxt_SearchButtonPressed(object sender, EventArgs e)
        {
            var Professionals = DummyProfessionalData.GetProfessionals();
            var keyWord = TextSearch.Text;
            if (string.IsNullOrEmpty(keyWord))
            {
                vm.Professionals = Professionals;
            }
            else
            {
                vm.Professionals = Professionals.Where(x => x.Name.ToLower().Contains(keyWord.ToLower())).ToList();
            }
        }
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            var Professionals = DummyProfessionalData.GetProfessionals();
            var keyWord = TextSearch.Text;
            if (string.IsNullOrEmpty(keyWord))
            {
                vm.Professionals = Professionals;
            }
            else
            {
                vm.Professionals = Professionals.Where(x => x.Name.ToLower().Contains(keyWord.ToLower())).ToList();
            }
        }
        private void DataGrid_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var detail = (Professional)e.SelectedItem;
            vm.SelectedProfesstional = detail;
            Navigation.PushAsync(new Detailpage(vm)); 
        }
    }
}
