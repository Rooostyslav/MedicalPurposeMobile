using MedicalPurposeMobile.Models;
using MedicalPurposeMobile.Services.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace MedicalPurposeMobile.Services
{
	public class PrescriptionService : BaseService, IPrescriptionService
	{
		private readonly string baseUrl;

		public PrescriptionService()
		{
			baseUrl = domain_api + "/api/prescriptions/";
		}

		public async Task<IEnumerable<ViewPrescription>> FindMyPrescriptionsAsync()
		{
			string url = baseUrl + "my/";
			return await GetQueryAsync<IEnumerable<ViewPrescription>>(url);
		}

		public async Task<ViewPrescription> FindPrescriptionByIdAsync(int prescriptionId)
		{
			string url = baseUrl + prescriptionId + "/";
			return await GetQueryAsync<ViewPrescription>(url);
		}

		public string FindQRCodePath(int prescriptionId)
		{
			string url = string.Format("{0}/qrcodes/prescription{1}.png",
				domain_api,
				prescriptionId);

			return url;
		}
	}
}
