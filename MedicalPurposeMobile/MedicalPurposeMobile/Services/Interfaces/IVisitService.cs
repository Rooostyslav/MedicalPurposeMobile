using MedicalPurposeMobile.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalPurposeMobile.Services.Interfaces
{
	public interface IVisitService
	{
		Task<IEnumerable<ViewVisit>> FindMyVisitsAsync();
	}
}
