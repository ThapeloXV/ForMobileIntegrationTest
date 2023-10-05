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
    }
}
