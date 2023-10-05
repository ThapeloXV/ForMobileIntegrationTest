using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using IntegrationTest.Assets.Helpers;
using Newtonsoft.Json;
using IntegrationTest.Models;

namespace IntegrationTest.ViewModels
{
    class PlacesViewModel
    {
        string token;
        public PlacesViewModel(string token)
        {
            //Constructor
            this.token = token;

        }

        public string GenerateUrl(string SearchCriteria)
        {
            //Generate the api url
            string url = string.Format(Constants.PLACES_SEARCH, SearchCriteria);

            return url;
        }

        public static async Task<string> GetToken()
        {
            String token = "";
            Login login = new Login();

            //New http client
            using (HttpClient client = new HttpClient())
            {

                
                var tokenRequestData = new FormUrlEncodedContent(new[]
                {
                       new KeyValuePair<string, string>("client_id",Constants.CLIENT_ID),
                       new KeyValuePair<string, string>("client_secret",Constants.CLIENT_SECRET),
                       new KeyValuePair<string, string>("grant_type","client_credentials"),
                });

                // Send the post request
                var response = await client.PostAsync(Constants.AUTH_URL, tokenRequestData);

                //Check if the request is successful
                if (response.IsSuccessStatusCode)
                {
                    //Read the token 
                    token = await response.Content.ReadAsStringAsync();

                    //Deserialize the token
                    var tokenObject = JsonConvert.DeserializeObject<TokenResponse>(token);
                    new PlacesViewModel(tokenObject.access_token);

                    token = tokenObject.access_token;
                    return token;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<PlacesResponse>> GetPlaces(string SearchCriteria)
        {
            try
            {
                List<PlacesResponse> place = new List<PlacesResponse>();

                string url = GenerateUrl(SearchCriteria);

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                    var response = await client.GetAsync(url);
                    var json = await response.Content.ReadAsStringAsync();

                    var root = JsonConvert.DeserializeObject<Root>(json);

                    place = root.Data as List<PlacesResponse>;
                }
                return place;
            }
            catch (UnauthorizedAccessException UAE)
            {
                throw UAE;
            }
            catch (HttpRequestException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
