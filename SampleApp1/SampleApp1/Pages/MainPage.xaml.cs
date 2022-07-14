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
            // bind view model
            vm = new MainPageViewModel();
            InitializeComponent();
            BindingContext = vm;            
        }

        // filter data on press enter
        private async void SearchTxt_SearchButtonPressed(object sender, EventArgs e)
        {
            var Professionals = await DummyProfessionalData.GetProfessionals();
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

        // filter data on typing 
        private async void SearchBar_TextChanged(object sender, EventArgs e)
        {
            // get data
            var Professionals = await DummyProfessionalData.GetProfessionals();
            var keyWord = TextSearch.Text;
            if (string.IsNullOrEmpty(keyWord))
            {
                vm.Professionals = Professionals;
            }
            else
            {
                // filter based on keywords
                vm.Professionals = Professionals.Where(x => x.Name.ToLower().Contains(keyWord.ToLower())).ToList();
            }
        }
        // row selection from grid
        private void DataGrid_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // get selected row
            var detail = (Professional)e.SelectedItem;
            vm.SelectedProfesstional = detail;
            
            // Navigate to detail page
            Navigation.PushAsync(new Detailpage(vm)); 
        }
    }
}
