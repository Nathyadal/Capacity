using Capacity.View.User;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Capacity.ViewModel
{
    public class LoginViewModel:NotifyChange
    {
		private string email;

		public string Email
		{
			get { return email; }
			set { 
				email = value;
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

		public MyCommand LoginCommand
		{
			get
			{
				return new MyCommand(Login);
			}
		}

		#region Logic
		private void Login()
		{
			//null or empty field validation, check weather email and password is null or empty  
			if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
				App.Current.MainPage.DisplayAlert("Valores vacios", "Por favor ingrese un correo y contraseña", "OK");
			else
			{
				if (Email == "hola" && Password == "1234")
				{
					//App.Current.MainPage.DisplayAlert("Login Success", "", "Ok");
					App.Current.MainPage = new NavigationPage(new UserMenu());
				}
				else
				{
					Password = "";
					App.Current.MainPage.DisplayAlert("Inicio sesión fallido", "Correo o contraseña incorrectos", "OK");
				}
			}
		}
		#endregion

	}
}
