using IntegrationTest.Assets.Helpers;
using IntegrationTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntegrationTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        protected override void OnAppearing()
        {
            var assembly = typeof(LoginPage);
            iconImage.Source = ImageSource.FromResource("IntegrationTest.Android.Assets.Images.travel-bag.png", assembly);
            emailEntry.Text = Constants.CLIENT_ID;
            passwordEntry.Text = Constants.CLIENT_SECRET;
        }

        private async void loginButton_Clicked(object sender, EventArgs e)
        {
            var navigate = LoginViewModel.EntryCheck(emailEntry.Text, passwordEntry.Text);
            string token = "";

            if (navigate == true)
            {
                token = await PlacesViewModel.GetToken();
                new PlacesViewModel(token);
                await Navigation.PushAsync(new Places(token));
            }
            else
            {
                emailEntry.Placeholder = "Enter a valid email";
                emailEntry.PlaceholderColor = Color.Red;

                passwordEntry.Placeholder = "Enter a valid password";
                passwordEntry.PlaceholderColor = Color.Red;
            }
        }
    }
}