using Capacity.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;

namespace Capacity.Services
{
    public abstract class GeneralInformationService
    {
        //Get Country list 
        public static ObservableCollection<Country> GetCountries()
        {
            try
            {
                var client = new RestClient("http://192.168.0.7:8080/countries");//link de ruta del lado del servidor
                RestRequest request = new RestRequest();//instancia del request propidad de restsharp
                request.Method = Method.GET;//se define que tipo de metodo va a buscar en este caso es un tipo get
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                var responses = client.Execute(request);
                if (responses.Content == "")
                { 
                    //not found                   
                }
                return JsonConvert.DeserializeObject<ObservableCollection<Country>>(responses.Content);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
