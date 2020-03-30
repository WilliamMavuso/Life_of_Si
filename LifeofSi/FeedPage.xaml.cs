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

        private TimeKeeper timeKeeper = new TimeKeeper();
        private static Timer timer;

        int clickTotal;

        public FeedPage()
        {
            InitializeComponent();
            StartTimer();
        }

        void ImageButton_Clicked(object sender, EventArgs e)
        {
            clickTotal += 1;
            leaves.Text = $"{clickTotal} /100";

            if (clickTotal >= 5)
            {
               clickTotal--;
               DisplayAlert("Warning " + userName.Text + "!", "Si is full. Come back again in 5 minutes", "Ok");
            }
        }

        //Timer events

            private void StartTimer()
        {
            timer = new Timer();

            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Elapsed += UpdateTimedData;
            timer.Start();
        }

        private void ResetTimer()
        {
            timeKeeper.StartTime = DateTime.Now;
            StartTimer();
        }

        private void UpdateTimedData(object sender, ElapsedEventArgs e)
        {
            TimeSpan timeElapsed = e.SignalTime - timeKeeper.StartTime;

            //CocoonState newCocoonState = Coccon.CurrentCocconState;

            if (timeElapsed.TotalSeconds < 10)
            {
                //newCocoonState = CocoonState.stage1;
            }
            else if (timeElapsed.TotalSeconds < 20)
            {
                //newCocoonState = CocoonState.stage2;
            }
            else if (timeElapsed.TotalSeconds >= 20)
            {
                //newCocoonState = CocoonState.stage3;
            }

            if (/*newCocoonState != Coccon.CurrentCocoonState*/ timeElapsed.TotalSeconds >= 20)
            {
                //Cocoon.CurrentCocoonState = newCocoonState;
                //updateUi();
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

        //void Entry_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        //{
        //    Application.Current.Properties["Name"] = userName.Text;
        //}

        //void userName_Completed(System.Object sender, System.EventArgs e)
        //{
        //    var text = ((Entry)sender).Text;

        //    //string text = userName.Text;
        //}
    }
}
