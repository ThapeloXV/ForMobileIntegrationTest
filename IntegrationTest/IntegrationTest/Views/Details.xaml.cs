using IntegrationTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegrationTest.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntegrationTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Details : ContentPage
    {
        private PlacesResponse placesResponse;
        string token; 
        public Details(PlacesResponse placesResponse, string token)
        {
            InitializeComponent();

            this.placesResponse = placesResponse;
            this.token = token;
            //placeLabel.Text = placesResponse.placeId;
        }

        protected async override void OnAppearing()
        {
            var myDetailsView = new DetailsViewModel(placesResponse,token);
            var detailRoot = await myDetailsView.GetPlaceDetail();

            if (detailRoot != null)
            {
                placeNameLabel.Text =detailRoot.name;

                placeAddress.Text =  detailRoot.formattedAddress;

                placeVicinity.Text =  detailRoot.vicinity;

                placeUrl.Text =  detailRoot.url;

                placeLongitude.Text = detailRoot.longitude.ToString();

                placeLatitude.Text =  detailRoot.latitude.ToString();

                placeUtcOffst.Text =  detailRoot.utcOffset.ToString();
                
            }
        }

    }
}