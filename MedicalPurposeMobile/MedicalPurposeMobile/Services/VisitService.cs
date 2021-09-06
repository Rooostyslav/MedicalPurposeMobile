using MedicalPurposeMobile.Models;
using MedicalPurposeMobile.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalPurposeMobile.Services
{
	public class VisitService : BaseService, IVisitService
	{
		private readonly string baseUrl;

		public VisitService()
		{
			baseUrl = domain_api + "/api/visits/";
		}

		public async Task<IEnumerable<ViewVisit>> FindMyVisitsAsync()
		{
			string url = baseUrl + "my/";
			return await GetQueryAsync<IEnumerable<ViewVisit>>(url);
		}
	}
}
