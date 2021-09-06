using System;

namespace MedicalPurposeMobile.Models
{
	public class ViewVisit
	{
		public int Id { get; set; }

		public int DoctorId { get; set; }

		public ViewDoctor Doctor { get; set; }

		public int PatientId { get; set; }

		public ViewPatient Patient { get; set; }

		public DateTime DateTime { get; set; }
	}
}
