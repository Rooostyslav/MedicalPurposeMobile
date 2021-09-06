using MedicalPurposeMobile.Models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MedicalPurposeMobile.ViewModels
{
	public class MedicinesListViewModel : BaseViewModel
	{
		private ViewMedicine selectedMedicine;

		public ObservableCollection<ViewMedicine> Medicines { get; }
		public Command LoadMedicinesCommand { get; }
		public Command<ViewMedicine> MedicineTapped { get; }

		public MedicinesListViewModel()
		{
			Medicines = new ObservableCollection<ViewMedicine>();

			LoadMedicinesCommand = new Command(async () => await ExecuteLoadMedicinesCommand());

			MedicineTapped = new Command<ViewMedicine>(OnMedicineSelected);
		}

		async Task ExecuteLoadMedicinesCommand()
		{
			IsBusy = true;

			try
			{
				Medicines.Clear();
				var medicines = await MedicineService.FindAllMedicineAsync();

				foreach (var medicine in medicines)
				{
					Medicines.Add(medicine);
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
			selectedMedicine = null;
		}

		public ViewMedicine SelectedMedicine
		{
			get => selectedMedicine;
			set
			{
				SetProperty(ref selectedMedicine, value);
				OnMedicineSelected(value);
			}
		}

		void OnMedicineSelected(ViewMedicine medicine)
		{
			if (medicine == null)
				return;

			//await Shell.Current.GoToAsync($"{nameof(GardenDetailPage)}?{nameof(GardenDetailViewModel.GardenId)}={prescription.Id}");
		}
	}
}
