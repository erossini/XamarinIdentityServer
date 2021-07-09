using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinIdentityServer.Services;
using XamarinIdentityServer.Views;

namespace XamarinIdentityServer
{
	public partial class App : Application
	{
		public const string CallbackUri = "oidcxamarin101";
		public static readonly string CallbackScheme = $"{CallbackUri}:/authenticated";
		public static readonly string SignoutCallbackScheme = $"{CallbackUri}:/signout-callback-oidc";

		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			MainPage = new MainPage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
