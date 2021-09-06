using MedicalPurposeMobile.Models;
using MedicalPurposeMobile.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalPurposeMobile.Services
{
	public class MedicineService : BaseService, IMedicineService
	{
		private readonly string baseUrl;

		public MedicineService()
		{
			baseUrl = domain_api + "/api/medicines/";
		}

		public async Task<IEnumerable<ViewMedicine>> FindAllMedicineAsync()
		{
			return await GetQueryAsync<IEnumerable<ViewMedicine>>(baseUrl);
		}
	}
}
