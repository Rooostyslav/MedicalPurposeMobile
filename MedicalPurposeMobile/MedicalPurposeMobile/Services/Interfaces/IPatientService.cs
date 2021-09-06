using MedicalPurposeMobile.Models;
using System.Threading.Tasks;

namespace MedicalPurposeMobile.Services.Interfaces
{
	public interface IPatientService
	{
		Task<bool> CreatePatientAsync(CreatePatient patient);
	}
}
