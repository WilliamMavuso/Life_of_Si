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

        // Swat Flies Functionality

        async void FlyButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await flyImage.FadeTo(0, 1000, Easing.SinOut);
            flyImage.IsVisible = false;
            await flyImage3.FadeTo(0, 1000, Easing.SinOut);
            flyImage.IsVisible = false;
        }

        async void FlyButton_Clicked1(System.Object sender, System.EventArgs e)
        {
            await flyImage1.FadeTo(0, 1000, Easing.SinOut);
            flyImage.IsVisible = false;
            await flyImage4.FadeTo(0, 1000, Easing.SinOut);
            flyImage.IsVisible = false;
        }

        async void FlyButton_Clicked2(System.Object sender, System.EventArgs e)
        {

            await flyImage2.FadeTo(0, 1000, Easing.SinOut);
            flyImage.IsVisible = false;
            await flyImage5.FadeTo(0, 1000, Easing.SinOut);
            flyImage.IsVisible = false;
        }

        async void FlyButton_Clicked3(System.Object sender, System.EventArgs e)
        {
            await flyImage3.FadeTo(0, 1000, Easing.SinOut);
            flyImage.IsVisible = false;
        }

        async void FlyButton_Clicked4(System.Object sender, System.EventArgs e)
        {
            await flyImage4.FadeTo(0, 1000, Easing.SinOut);
            flyImage.IsVisible = false;
        }

        async void FlyButton_Clicked5(System.Object sender, System.EventArgs e)
        {
            await flyImage5.FadeTo(0, 1000, Easing.SinOut);
            flyImage.IsVisible = false;
        }

        async void FlyButton_Clicked6(System.Object sender, System.EventArgs e)
        {
            await flyImage6.FadeTo(0, 1000, Easing.SinOut);
            flyImage.IsVisible = false;
        }

        async void FlyButton_Clicked7(System.Object sender, System.EventArgs e)
        {
            await flyImage7.FadeTo(0, 1000, Easing.SinOut);
            flyImage.IsVisible = false;
        }

        async void FlyButton_Clicked8(System.Object sender, System.EventArgs e)
        {
            await flyImage8.FadeTo(0, 1000, Easing.SinOut);
            flyImage.IsVisible = false;
        }

    }
}
