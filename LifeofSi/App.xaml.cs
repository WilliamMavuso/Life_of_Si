using System;
using LifeofSi.Objects;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LifeofSi
{
    public partial class App : Application
    {
        private TimeKeeper timeKeeper = new TimeKeeper();
        public App()
        {
            InitializeComponent();

            MainPage = new StartingPage();
        }

        protected override void OnStart()
        {
            Console.WriteLine("OnStart");

            Console.WriteLine(timeKeeper.StoredTime);
            //Console.WriteLine(timeKeeper.GetTimeElapsed);
        }

        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");
            timeKeeper.StoredTime = DateTime.Now;
        }

        protected override void OnResume()
        {
            Console.WriteLine("OnResume");

            Console.WriteLine(timeKeeper.StoredTime);
            //Console.WriteLine(timeKeeper.GetTimeElapsed);
        }
    }
}
