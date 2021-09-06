using MedicalPurposeMobile.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalPurposeMobile.Services.Interfaces
{
	public interface IMedicineService
	{
		Task<IEnumerable<ViewMedicine>> FindAllMedicineAsync();
	}
}
