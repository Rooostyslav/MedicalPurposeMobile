using MedicalPurposeMobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MedicalPurposeMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrescriptionDetailPage : ContentPage
	{
		public PrescriptionDetailPage()
		{
			InitializeComponent();
			BindingContext = new PrescriptionDetailViewModel();
		}
	}
}