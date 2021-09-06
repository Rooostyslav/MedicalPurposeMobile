using MedicalPurposeMobile.Models;
using System.Threading.Tasks;

namespace MedicalPurposeMobile.Services.Interfaces
{
	public interface IAuthService
	{
		Task<bool> LoginAsync(Login login);

		Task<ViewPatient> FindMyInfoAsync();

		Task<bool> IsLogged();

		Task<bool> Logout();
	}
}
