using Capacity.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Capacity.ViewModel
{
    public class MainPageViewModel: NotifyChange
    {

		public Command Login
		{
			get
			{
				return new Command(LoginPageRedirect);
			}
		}

		public Command CompanyRegister
		{
			get
			{
				return new Command(CompanyRegisterPageRedirect);
			}
		}

		public Command UserRegister
		{
			get
			{
				return new Command(UserRegisterPageRedirect);
			}
		}

		#region Logic
		private void  LoginPageRedirect()
		{
			App.Current.MainPage = new NavigationPage(new Login());
		}
		private void CompanyRegisterPageRedirect()
		{
			App.Current.MainPage=new NavigationPage(new Login());
		}
		private void UserRegisterPageRedirect()
		{
			App.Current.MainPage=new NavigationPage(new Login());
		}
		#endregion
	}
}
