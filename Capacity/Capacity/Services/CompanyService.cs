using Capacity.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Capacity.Services
{
    public abstract class CompanyService
    {
        //Create company
        public static bool SendNewCompany(Company company)
        {
            try
            {
                var client = new RestClient("http://192.168.0.7:8080/countries");//link de ruta del lado del servidor
                RestRequest request = new RestRequest();//instancia del request propidad de restsharp
                request.Method = Method.POST;//se define que tipo de metodo va a buscar en este caso es un tipo get
                request.AddParameter("company", company);
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                var responses = client.Execute(request);
                if (responses.Content == "true")
                {
                    App.Current.MainPage.DisplayAlert("Confirmación", "Se ha registrado la compañia satisfactoriamente", "ok");
                    return true;
                }
                App.Current.MainPage.DisplayAlert("Error", "No se ha actualizado podido actualizar, intente de nuevo", "ok");
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Create branch
        public static bool SendNewBranch(Branch branch)
        {
            try
            {
                var client = new RestClient("http://192.168.0.7:8080/countries");//link de ruta del lado del servidor
                RestRequest request = new RestRequest();//instancia del request propidad de restsharp
                request.Method = Method.POST;//se define que tipo de metodo va a buscar en este caso es un tipo get
                request.AddParameter("branch", branch);
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                var responses = client.Execute(request);
                if (responses.Content == "true")
                {
                    App.Current.MainPage.DisplayAlert("Confirmación", "Se ha registrado la sede satisfactoriamente", "ok");
                    return true;
                }
                App.Current.MainPage.DisplayAlert("Error", "No se ha actualizado podido actualizar, intente de nuevo", "ok");
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Create record and update capacity
        public static bool SendNewRecord(Record record)
        {
            try
            {
                var client = new RestClient("http://192.168.0.7:8080/countries");//link de ruta del lado del servidor
                RestRequest request = new RestRequest();//instancia del request propidad de restsharp
                request.Method = Method.POST;//se define que tipo de metodo va a buscar en este caso es un tipo get
                request.AddParameter("record", record);
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                var responses = client.Execute(request);
                if (responses.Content == "true")
                {
                    return true;
                }
                App.Current.MainPage.DisplayAlert("Error", "No se ha actualizado podido actualizar, intente de nuevo", "ok");
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
