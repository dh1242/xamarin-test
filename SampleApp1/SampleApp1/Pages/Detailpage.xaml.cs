using SampleApp1.Models;
using SampleApp1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detailpage : ContentPage
	{
        MainPageViewModel vm;
        public Detailpage (MainPageViewModel vm)
		{
            InitializeComponent ();
            BindingContext = vm;
        }
	}
}