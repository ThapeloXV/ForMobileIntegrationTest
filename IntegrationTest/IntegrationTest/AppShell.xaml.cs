using IntegrationTest.ViewModels;
using IntegrationTest.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace IntegrationTest
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        }

    }
}
