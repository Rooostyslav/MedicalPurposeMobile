using MedicalPurposeMobile.Models;
using MedicalPurposeMobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MedicalPurposeMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage
	{
		public CreatePatient User;

		public RegisterPage()
		{
			InitializeComponent();
			BindingContext = new RegisterViewModel();
		}
	}
}