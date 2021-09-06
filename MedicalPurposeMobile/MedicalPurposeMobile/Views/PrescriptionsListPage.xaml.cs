using MedicalPurposeMobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MedicalPurposeMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrescriptionsListPage : ContentPage
	{
		PrescriptionsListViewModel viewModel;

		public PrescriptionsListPage()
		{
			InitializeComponent();
			BindingContext = viewModel = new PrescriptionsListViewModel();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			viewModel.OnAppearing();
		}
	}
}