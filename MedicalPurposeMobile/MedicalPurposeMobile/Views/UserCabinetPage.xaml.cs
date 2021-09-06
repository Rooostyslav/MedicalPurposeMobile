using MedicalPurposeMobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MedicalPurposeMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserCabinetPage : ContentPage
	{
		public UserCabinetPage()
		{
			InitializeComponent();
			BindingContext = new UserCabinetViewModel();
		}
	}
}