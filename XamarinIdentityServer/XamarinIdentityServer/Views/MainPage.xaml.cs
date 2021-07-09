using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinIdentityServer.ViewModels;

namespace XamarinIdentityServer.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		MainViewModel vm;

		public MainPage()
		{
			InitializeComponent();

			vm = new MainViewModel();
			BindingContext = vm;
		}
	}
}