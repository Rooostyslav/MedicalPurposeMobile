using MedicalPurposeMobile.Services;
using Xamarin.Forms;

namespace MedicalPurposeMobile
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			DependencyService.Register<AuthService>();
			DependencyService.Register<VisitService>();
			DependencyService.Register<PrescriptionService>();
			DependencyService.Register<MedicineService>();
			DependencyService.Register<PatientService>();

			MainPage = new AppShell();

			Shell.Current.GoToAsync("LoginPage");

			CheckLogin();
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

		private void CheckLogin()
		{
			//var authService = DependencyService.Get<IAuthService>();
			//bool isLogged = authService.IsLogged().Result;

			//if (!isLogged)
			//{
			//	Shell.Current.GoToAsync("LoginPage");
			//}
		}
	}
}
