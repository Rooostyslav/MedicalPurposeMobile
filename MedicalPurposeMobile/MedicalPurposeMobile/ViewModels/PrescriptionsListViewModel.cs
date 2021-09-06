using MedicalPurposeMobile.Models;
using MedicalPurposeMobile.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MedicalPurposeMobile.ViewModels
{
	public class PrescriptionsListViewModel : BaseViewModel
	{
		private ViewPrescription selectedPrescription;

		public ObservableCollection<ViewPrescription> Prescriptions { get; }
		public Command LoadPrescriptionsCommand { get; }
		public Command<ViewPrescription> PrescriptionTapped { get; }

		public PrescriptionsListViewModel()
		{
			Prescriptions = new ObservableCollection<ViewPrescription>();

			LoadPrescriptionsCommand = new Command(async () => await ExecuteLoadPrescriptionsCommand());

			PrescriptionTapped = new Command<ViewPrescription>(OnPrescriptionSelected);
		}

		async Task ExecuteLoadPrescriptionsCommand()
		{
			IsBusy = true;

			try
			{
				Prescriptions.Clear();
				var prescriptions = await PrescriptionService.FindMyPrescriptionsAsync();

				foreach(var prescription in prescriptions)
				{
					Prescriptions.Add(prescription);
				}

			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			finally
			{
				IsBusy = false;
			}
		}

		public void OnAppearing()
		{
			IsBusy = true;
			selectedPrescription = null;
		}

		public ViewPrescription SelectedPrescription
		{
			get => selectedPrescription;
			set
			{
				SetProperty(ref selectedPrescription, value);
				OnPrescriptionSelected(value);
			}
		}

		async void OnPrescriptionSelected(ViewPrescription prescription)
		{
			if (prescription == null)
				return;

			await Shell.Current.GoToAsync($"{nameof(PrescriptionDetailPage)}?{nameof(PrescriptionDetailViewModel.PrescriptionId)}={prescription.Id}");
		}
	}
}
