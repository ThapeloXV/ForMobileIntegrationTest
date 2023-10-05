using System;
using System.Collections.Generic;
using System.Text;
using IntegrationTest.Assets.Helpers;
using Newtonsoft.Json;
using IntegrationTest.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace IntegrationTest.ViewModels
{
   
    class DetailsViewModel
    {
        private PlacesResponse placesResponse;
        string token;
        public DetailsViewModel(PlacesResponse placesResponse, string token)
        {
            this.placesResponse = placesResponse;
            this.token = token;
        }

        public string GenerateDetailUrl(string placeId)
        {
            //Generate the api url
            string url = string.Format(Constants.PLACES_DETAIL_SEARCH, placeId);

            return url;
        }

        public async Task<DetailRoot> GetPlaceDetail()
        {
            try
            {
                DetailRoot details = new DetailRoot();

                string url = GenerateDetailUrl(placesResponse.placeId);

                using (HttpClient client = new HttpClient())
                {
                    //Authorise the connection to the API
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                    //Get the response
                    var response =await client.GetAsync(url);

                    //Get the API data
                    var json = await response.Content.ReadAsStringAsync();

                    //Deserialize the API data
                    var root = JsonConvert.DeserializeObject<Root2>(json);

                    details = root.data;
                }
                return details;
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
