using MedicalPurposeMobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MedicalPurposeMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MedicinesListPage : ContentPage
	{
		MedicinesListViewModel viewModel;

		public MedicinesListPage()
		{
			InitializeComponent();
			BindingContext = viewModel = new MedicinesListViewModel();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			viewModel.OnAppearing();
		}
	}
}