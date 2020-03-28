using System;
using System.Collections.Generic;
using LifeofSi.Objects;
using Xamarin.Forms;

namespace LifeofSi
{
    public partial class FeedPage : ContentPage
    {
        
        int clickTotal;

        public FeedPage()
        {
            InitializeComponent();
        }

        void ImageButton_Clicked(object sender, EventArgs e)
        {
            clickTotal += 1;
            leaves.Text = $"{clickTotal} /100";

            if (clickTotal >= 5)
            {
               clickTotal--;
               DisplayAlert("Warning", "Si is full. Come back again in 5 minutes", "Ok");
            }
        }

        async void LeafButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new FeedPage());
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

        void Entry_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            Application.Current.Properties["Name"] = userName.Text;
        }

        void userName_Completed(System.Object sender, System.EventArgs e)
        {
            var text = ((Entry)sender).Text;

            //string text = userName.Text;
        }
    }
}
