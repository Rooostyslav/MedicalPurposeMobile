using MedicalPurposeMobile.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalPurposeMobile.Services.Interfaces
{
	public interface IPrescriptionService
	{
		Task<IEnumerable<ViewPrescription>> FindMyPrescriptionsAsync();

		Task<ViewPrescription> FindPrescriptionByIdAsync(int prescriptionId);

		string FindQRCodePath(int prescriptionId);
	}
}
