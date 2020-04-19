using Capacity.Model;
using Capacity.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Capacity.ViewModel.Company
{
    public class CompanyRegisterViewModel:NotifyChange
    {
		private ObservableCollection<Country> country;

		public ObservableCollection<Country> Country
		{
			get { return country; }
			set { country = value; }
		}

		public CompanyRegisterViewModel()
		{
			country = new ObservableCollection<Country>();
			//country = GeneralInformationService.GetCountries();
		}

		private int id_Country;

		public int Id_Country
		{
			get { return id_Country; }
			set { 
				id_Country = value;
				NotifyPropertyChanged();			
			}
		}

		private int legalCertificate;

		public int LegalCertificate
		{
			get { return legalCertificate; }
			set { 
				legalCertificate = value;
				NotifyPropertyChanged();
			}
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { 
				name = value;
				NotifyPropertyChanged();
			}
		}

		private string password;

		public string Password
		{
			get { return password; }
			set { 
				password = value;
				NotifyPropertyChanged();
			}
		}

	
	}
}
