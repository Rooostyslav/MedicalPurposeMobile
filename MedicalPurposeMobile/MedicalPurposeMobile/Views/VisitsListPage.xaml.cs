using MedicalPurposeMobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MedicalPurposeMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VisitsListPage : ContentPage
	{
		VisitsListViewModel viewModel;

		public VisitsListPage()
		{
			InitializeComponent();
			BindingContext = viewModel = new VisitsListViewModel();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			viewModel.OnAppearing();
		}
	}
}