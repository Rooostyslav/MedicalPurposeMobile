using MedicalPurposeMobile.Views;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MedicalPurposeMobile.ViewModels
{
	public class UserCabinetViewModel : BaseViewModel
	{
		private string name;
		private string email;

		public int Id { get; set; }

		public string Name
		{
			get => name;
			set => SetProperty(ref name, value);
		}

		public string Email
		{
			get => email;
			set => SetProperty(ref email, value);
		}

		public Command MoveToPrescriptionsListCommand { get; }

		public UserCabinetViewModel()
		{
			MoveToPrescriptionsListCommand = new Command(async () => await ExecuteMoveToPrescriptionsListCommand());

			LoadUser();
		}

		private async Task ExecuteMoveToPrescriptionsListCommand()
		{
			await Shell.Current.GoToAsync($"{nameof(PrescriptionsListPage)}");
		}

		private async void LoadUser()
		{
			try
			{
				var user = await AuthService.FindMyInfoAsync();
				Id = user.Id;
				Name = user.FullName;
				Email = user.Email;
			}
			catch (Exception e)
			{
				Debug.WriteLine("Failed to Load Item");
			}
		}
	}
}
