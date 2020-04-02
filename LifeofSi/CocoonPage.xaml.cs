using System;
using System.Collections.Generic;
using System.Timers;
using Xamarin.Forms;

namespace LifeofSi
{

    public partial class CocoonPage : ContentPage
    {

        int tapCount;

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

        void transformImage_Clicked(System.Object sender, System.EventArgs e)
        {
            (sender as ImageButton).Source = ImageSource.FromFile("stage_2.png");
        }

        // transform functionality
       public void OnTapGestureRecognizerTapped(object sender, EventArgs args)

        {
            tapCount++;
            var imageSender = (Image)sender;


            if (tapCount % 2 == 1)
            {
                imageSender.Source = "moth.png";
                timerUpdate.Text = "Si is now a moth.";
                percentage.Text = "50%";
                mainProgressBar.Progress = 0.5;
            }
            else if (tapCount % 2 == 0)
            {
                imageSender.Source = "stage_3.png";
                timerUpdate.Text = "Yay! Si has evolved into a butterfly.";
                percentage.Text = "100%";
                mainProgressBar.Progress = 1;
            }

        }

    }
}
