using IntegrationTest.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using IntegrationTest.Models;
using System.Threading.Tasks;
using IntegrationTest.Assets.Helpers;
using Newtonsoft.Json;
using System.Net.Http;

namespace IntegrationTest.ViewModels
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {

        }

        public static bool EntryCheck(string email, string password)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(email);
            bool isPasswordEmpty = string.IsNullOrEmpty(password);

            if (isEmailEmpty || isPasswordEmpty)
            {
                // Do not navigate
                return false;
            }
            else
            {
                // Navigate
                return true;
            }

        }

         //public  static async Task<string> GetToken()
         //{
         //   String token="";
         //   Login login = new Login();

         //   //New http client
         //   using (HttpClient client = new HttpClient())
         //   {

         //       //
         //       var tokenRequestData = new FormUrlEncodedContent(new[]
         //       {
         //              new KeyValuePair<string, string>("client_id",Constants.CLIENT_ID),
         //              new KeyValuePair<string, string>("client_secret",Constants.CLIENT_SECRET),
         //              new KeyValuePair<string, string>("grant_type","client_credentials"),
         //       });

         //       // Send the post request
         //       var response = await client.PostAsync(Constants.AUTH_URL, tokenRequestData);

         //       //Check if the request is successful
         //       if (response.IsSuccessStatusCode)
         //       {
         //           //
         //           token = await response.Content.ReadAsStringAsync();
         //           var tokenObject = JsonConvert.DeserializeObject<TokenResponse>(token);
         //           new PlacesViewModel(tokenObject.access_token);

         //           token = tokenObject.access_token;
                    

         //           Console.WriteLine("Token", tokenObject.access_token);
         //       }
         //       else
         //       {
         //           Console.WriteLine(response.StatusCode);
         //       }
         //   }

         //   return token;
         //}
    }
}
