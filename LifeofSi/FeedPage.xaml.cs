using System;
using System.Collections.Generic;
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

            //StartTimer();
            //updateUi();
        }

        void ImageButton_Clicked(object sender, EventArgs e)
        {
            clickTotal += 1;
            Xplabel.Text = $"{clickTotal} /100";



            if (clickTotal >= 5)
            {
                clickTotal--;
                DisplayAlert("Warning " + userName.Text + " :", "Si is full. Come feed her again in 5 minutes.", "Ok");
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

        //private TimeKeeper timeKeeper = new TimeKeeper();
        //private static Timer timer;
        //private Si si = new Si();


        //void updateUi()
        //{
        //    int siXp = si.Xp;

        //    if (siXp < 1)
        //    {
        //        level.Text = "Feed Me";
        //        Xplabel.Text = "Tap on me to feed me.";
        //    }
        //    else
        //    {
        //        level.Text = "Lvl. " + Levels.GetLevelFromXp(siXp).ToString();
        //        Xplabel.Text = siXp.ToString();
        //    }

        //    //userName.Text = si.SiName;

        //    Device.BeginInvokeOnMainThread(async () =>
        //    {
        //        siImage.Source = "green_worm" + si.CurrentSiState + "_" + (Levels.GetLevelFromXp(siXp) + 1).ToString();

        //        if (si.CurrentSiState == SiState.stage1)

        //        {
        //            SiStage();
        //        }
        //    });

        //}

        //private async void SiStage()
        //{
        //    //await DisplayAlert("Hungry ", "Si is hungry. Tap on her to feed her", "Ok");

        //    si.Xp = 1;
        //    si.CurrentSiState = SiState.stage1;
        //    updateUi();
        //}


        //Timer events

        //    private void StartTimer()
        //{
        //    timer = new Timer();

        //    timer.Interval = 1000;
        //    timer.Enabled = true;
        //    timer.Elapsed += UpdateTimedData;
        //    timer.Start();
        //}

        //private void ResetTimer()
        //{
        //    timeKeeper.StartTime = DateTime.Now;
        //    StartTimer();
        //}

        //private void UpdateTimedData(object sender, ElapsedEventArgs e)
        //{
        //    TimeSpan timeElapsed = e.SignalTime - timeKeeper.StartTime;

        //    SiState newSiState = si.CurrentSiState;

        //    if (timeElapsed.TotalSeconds < 10)
        //    {
        //        newSiState = SiState.stage1;
        //    }
        //    else if (timeElapsed.TotalSeconds < 20)
        //    {
        //        newSiState = SiState.stage2;
        //    }
        //    else if (timeElapsed.TotalSeconds >= 20)
        //    {
        //        newSiState = SiState.stage3;
        //    }

        //    if (newSiState != si.CurrentSiState)
        //    {
        //        si.CurrentSiState = newSiState;
        //        updateUi();
        //    }
        //}

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
