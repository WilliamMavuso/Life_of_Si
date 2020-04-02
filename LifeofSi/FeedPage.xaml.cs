using System;
using System.Collections.Generic;
using LifeofSi.Objects;
//using System.Threading;
using System.Timers;
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

        // LevelXp functionality

       public void ImageButton_Clicked(object sender, EventArgs e)
        {
            clickTotal += 1;
           
            Xplabel.Text = $"{clickTotal} /20";

            if (clickTotal >= 10)
            {

                level.Text = "Lvl.2";
                level.TextColor = Color.HotPink;
                (sender as ImageButton).Source = ImageSource.FromFile("purple_worm");
            }

            if (clickTotal == 20)
            {
                clickTotal--;
                DisplayAlert("Congratulations " + userName.Text + "!", "Si is now completely full.", "Ok");
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

    }
}
