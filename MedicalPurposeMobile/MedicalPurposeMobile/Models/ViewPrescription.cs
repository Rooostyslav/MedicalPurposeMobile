using System.Collections.Generic;

namespace MedicalPurposeMobile.Models
{
	public class ViewPrescription
	{
		public int Id { get; set; }

		public int DoctorId { get; set; }

		public ViewDoctor Doctor { get; set; }

		public int PatientId { get; set; }

		public ViewPatient Patient { get; set; }

		public string Description { get; set; }

		public IEnumerable<ViewPrescriptionMedicine> Medicines { get; set; }
	}
}
