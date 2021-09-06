using MedicalPurposeMobile.Models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MedicalPurposeMobile.ViewModels
{
	public class VisitsListViewModel : BaseViewModel
	{
		private ViewVisit selectedVisit;

		public ObservableCollection<ViewVisit> Visits { get; }
		public Command LoadVisitsCommand { get; }
		public Command<ViewVisit> VisitTapped { get; }

		public VisitsListViewModel()
		{
			Visits = new ObservableCollection<ViewVisit>();

			LoadVisitsCommand = new Command(async () => await ExecuteLoadVisitsCommand());

			VisitTapped = new Command<ViewVisit>(OnVisitSelected);
		}

		async Task ExecuteLoadVisitsCommand()
		{
			IsBusy = true;

			try
			{
				Visits.Clear();
				var visits = await VisitService.FindMyVisitsAsync();

				foreach (var visit in visits)
				{
					Visits.Add(visit);
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
			selectedVisit = null;
		}

		public ViewVisit SelectedVisit
		{
			get => selectedVisit;
			set
			{
				SetProperty(ref selectedVisit, value);
				OnVisitSelected(value);
			}
		}

		void OnVisitSelected(ViewVisit visit)
		{
			if (visit == null)
				return;

			//await Shell.Current.GoToAsync($"{nameof(GardenDetailPage)}?{nameof(GardenDetailViewModel.GardenId)}={prescription.Id}");
		}
	}
}
