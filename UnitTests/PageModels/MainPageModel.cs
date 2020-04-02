using NUnit.Framework;
using System;
using LifeofSi;
using Xamarin.Forms;

namespace UnitTests.PageModels
{
    [TestFixture]
    public class MainPageModel
    {
        [Test]
        public void ImageButton_Clicked()
        {
            var feedPage = new FeedPage();

            feedPage.ImageButton_Clicked.Execute(null);
            object clickTotal = null;
            Assert.AreEqual(Label.Text = $"{clickTotal} /20", feedPage.Xplabel);
        }
    }
}
