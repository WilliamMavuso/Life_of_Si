using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LifeofSi
{
    public partial class FliesPage : ContentPage
    {
        public FliesPage()
        {
            InitializeComponent();
        }

        async void LeafButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new FeedPage());
        }

        async void CocoonButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new CocoonPage(""));
        }

        async void SwatButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new FliesPage());
        }

        async void BasketButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MarketPage());
        }

        async void FlyButton_Clicked(System.Object sender, System.EventArgs e)
        {
            //await flyImage.FadeTo(0, 1000, Easing.SinOut);
            //flyImage.IsVisible = false;
            await DisplayAlert("Test", "Clicked!!", "OK");

        }

    }
}
