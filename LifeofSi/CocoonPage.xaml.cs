using System;
using System.Collections.Generic;
using System.Timers;
using LifeofSi.Objects;
using Xamarin.Forms;

namespace LifeofSi
{
    public partial class CocoonPage : ContentPage
    {

        public CocoonPage(string parameter)
        {
            InitializeComponent();

            userName.Text = parameter;
        }

        async void LeafButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void CocoonButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new CocoonPage(userName.Text));
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
