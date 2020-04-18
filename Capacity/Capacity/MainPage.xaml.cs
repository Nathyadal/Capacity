using Capacity.Utils;
using Capacity.View;
using Capacity.View.Company;
using Capacity.View.User;
using Capacity.ViewModel;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Capacity
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //SUSCRIBE MESSAGE TO GET THE MENU OPTION SELECTED BY THE USER IN THE INTERFECE
            //THIS VALUES ARE COMING FROM MAINPAGEVIEWMODEL AND USE MESSAGIN CENTERIS A WAY TO 
            //UNDOP THE ELEMENTS FROM VIEW
            MessagingCenter.Subscribe<MainPageViewModel>(this, MainPageConstant.login, (a) =>
            {
                Navigation.PushAsync(new Login());
            });
            MessagingCenter.Subscribe<MainPageViewModel>(this, MainPageConstant.companyRegister, (a) =>
            {
                Navigation.PushAsync(new CompanyRegister());
            });
            MessagingCenter.Subscribe<MainPageViewModel>(this, MainPageConstant.userRegister, (a) =>
            {
                Navigation.PushAsync(new UserRegister());
            });
        }
    }
}
