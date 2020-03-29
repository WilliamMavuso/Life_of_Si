using System;
using System.Collections.Generic;
using System.Timers;
using Xamarin.Forms;

namespace LifeofSi
{
    public partial class CocoonPage : ContentPage
    {

        //int timeLeft;

        public CocoonPage(string parameter)
        {
            InitializeComponent();
            userName.Text = parameter;


            //Timer T = new Timer();
            //int Minutes = 5;
            //int Seconds = 0;

            //Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            //{
            //    // Do something
            //    DisplayAlert("Warning " + userName.Text + "!", "Si is full. Come back again in 5 minutes", "Ok");

            //    return true; // True = Repeat again, False = Stop the timer
            //});
        }

        //public Fivemintimer()
        //{
        //    T.Interval = 1000;
        //    T.Tick += new EventHandler(T_Tick);
        //}

        void OnSwiped(object sender, SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Left:
                    //transformImage.Source = Image.Source = stage_2;

                    break;
                case SwipeDirection.Right:
                    // Handle the swipe
                    break;
            }
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
    }
}
