using EmlakUygulamasi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmlakUygulamasi.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HousePage : ContentPage
	{
		public HousePage()
		{
			InitializeComponent();
			//BindingContext = new HousePageViewModel();

		}
	}
}