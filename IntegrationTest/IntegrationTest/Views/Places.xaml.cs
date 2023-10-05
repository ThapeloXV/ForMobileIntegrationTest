using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using IntegrationTest.ViewModels;
using IntegrationTest.Models;
using System.Collections.ObjectModel;

namespace IntegrationTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Places : ContentPage
    {
        string token;

         ObservableCollection<PlacesResponse> MyPlaces { get; set; }
        public Places(string token)
        {
            InitializeComponent();
            this.token = token;
        }

        private async void searchButton_Clicked(object sender, EventArgs e)
        {
            var search = searchEntry.Text;
            bool isSearchEmpty = string.IsNullOrEmpty(search);

            if (isSearchEmpty)
            {
                searchEntry.Placeholder = "Enter a search criteria";
                searchEntry.TextColor = Color.Red;
            }
            else
            {
                var placeModel = new PlacesViewModel(token);
                var myPlaces = await placeModel.GetPlaces(search);

                if (myPlaces != null)
                {
                    placesListView.ItemsSource = myPlaces;
                }
            }
        }

        private void placesListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedPost = placesListView.SelectedItem as PlacesResponse;

            if (selectedPost != null)
            {
                new DetailsViewModel(selectedPost,token);
                Navigation.PushAsync(new Details(selectedPost,token));
            }
        }
    }
}