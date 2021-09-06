using MedicalPurposeMobile.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using Xamarin.Forms;

namespace MedicalPurposeMobile.ViewModels
{
	[QueryProperty(nameof(PrescriptionId), nameof(PrescriptionId))]
	public class PrescriptionDetailViewModel : BaseViewModel
	{
		private int prescriptionId;
		private string qrCodeImageUrl;
		private string doctorName;
		private string patientName;
		private string description;
		private double totalPrice;

		public string QRCodeImageUrl
		{
			get => qrCodeImageUrl;
			set => SetProperty(ref qrCodeImageUrl, value);
		}

		public int Id { get; set; }

		public string DoctorName
		{
			get => doctorName;
			set => SetProperty(ref doctorName, value);
		}

		public string PatientName
		{
			get => patientName;
			set => SetProperty(ref patientName, value);
		}

		public string Description
		{
			get => description;
			set => SetProperty(ref description, value);
		}

		public double TotalPrice
		{
			get => totalPrice;
			set => SetProperty(ref totalPrice, value);
		}

		public int PrescriptionId
		{
			get
			{
				return prescriptionId;
			}
			set
			{
				prescriptionId = value;
				LoadPrescriptionId(value);
			}
		}

		public async void LoadPrescriptionId(int prescriptionId)
		{
			try
			{
				var prescription = await PrescriptionService.FindPrescriptionByIdAsync(prescriptionId);
				Id = prescription.Id;
				
				DoctorName = prescription.Doctor.FullName;
				PatientName = prescription.Patient.FullName;
				Description = prescription.Description;

				double temp = 0;
				foreach(var medicine in prescription.Medicines)
				{
					temp += medicine.TotalPrice;
				}
				TotalPrice = temp;

				QRCodeImageUrl = PrescriptionService.FindQRCodePath(prescriptionId);
			}
			catch (Exception)
			{
				Debug.WriteLine("Failed to Load Item");
			}
		}

	}
}
