﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LifeofSi
{
    public partial class MarketPage : ContentPage
    {
        public MarketPage()
        {
            InitializeComponent();
        }

        async void LeafButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new FeedPage());
        }

        async void CocoonButton_Clicked(System.Object sender, System.EventArgs e)
        {
<<<<<<< HEAD
            await Navigation.PushModalAsync(new CocoonPage());
=======
            await Navigation.PopModalAsync();
>>>>>>> Clean-front-end-branch
        }

        async void SwatButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new FliesPage());
        }

        async void BasketButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MarketPage());
        }
    }
}
