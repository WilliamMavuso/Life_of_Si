using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LifeofSi
{
    public partial class CocoonPage : ContentPage
    {
        public CocoonPage()
        {
            InitializeComponent();
        }

        async void LeafButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void CocoonButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new CocoonPage());
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
