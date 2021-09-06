using MedicalPurposeMobile.Models;
using MedicalPurposeMobile.Services.Interfaces;
using System.Net;
using System.Threading.Tasks;

namespace MedicalPurposeMobile.Services
{
	public class PatientService : BaseService, IPatientService
	{
		private readonly string baseUrl;

		public PatientService()
		{
			baseUrl = domain_api + "/api/patients/";
		}

		public async Task<bool> CreatePatientAsync(CreatePatient patient)
		{
			var response = await PostQueryWithResponseAsync(baseUrl, patient);

			if (response.StatusCode == HttpStatusCode.OK)
			{
				return true;
			}

			return false;
		}
	}
}
