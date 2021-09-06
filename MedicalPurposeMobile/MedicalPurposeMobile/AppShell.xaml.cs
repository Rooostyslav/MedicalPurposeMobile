using MedicalPurposeMobile.Services.Interfaces;
using MedicalPurposeMobile.Views;
using System;
using Xamarin.Forms;

namespace MedicalPurposeMobile
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();

			Routing.RegisterRoute(nameof(PrescriptionsListPage), typeof(PrescriptionsListPage));
			Routing.RegisterRoute(nameof(PrescriptionDetailPage), typeof(PrescriptionDetailPage));

			Routing.RegisterRoute(nameof(UserCabinetPage), typeof(UserCabinetPage));
			Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
			Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
		}

		private async void OnMenuItemClicked(object sender, EventArgs e)
		{
			var authService = DependencyService.Get<IAuthService>();
			await authService.Logout();

			await Shell.Current.GoToAsync($"{nameof(LoginPage)}");
		}
	}
}
