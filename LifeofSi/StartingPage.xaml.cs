using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LifeofSi
{
    public partial class StartingPage : ContentPage
    {
        public StartingPage()
        {
            InitializeComponent();
        }

        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new FeedPage());
        }
    }
}
