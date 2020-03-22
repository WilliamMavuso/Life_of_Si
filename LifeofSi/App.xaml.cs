﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LifeofSi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LifeofSi.MainPage();
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
