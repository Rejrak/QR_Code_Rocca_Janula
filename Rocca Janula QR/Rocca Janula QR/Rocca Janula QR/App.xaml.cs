﻿using Rocca_Janula_QR.Services;
using Rocca_Janula_QR.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rocca_Janula_QR
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            MainPage = new HomePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
