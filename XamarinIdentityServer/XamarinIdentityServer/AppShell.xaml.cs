using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinIdentityServer.ViewModels;
using XamarinIdentityServer.Views;

namespace XamarinIdentityServer
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
		}

		private async void OnMenuItemClicked(object sender, EventArgs e)
		{
			//await Shell.Current.GoToAsync("//LoginPage");
		}
	}
}
