using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LifeofSi
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();

            MainPage = new StartingPage();
        }

        protected override void OnStart()
        {
            Console.WriteLine("OnStart");

            //Console.WriteLine(timeKeeper.GetTimeElapsed);
        }

        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");
        }

        protected override void OnResume()
        {
            Console.WriteLine("OnResume");

            //Console.WriteLine(timeKeeper.GetTimeElapsed);
        }
    }
}
