using NUnit.Framework;
using System;
using LifeofSi;
using Xamarin.Forms;

namespace UnitTests.PageModels
{
    [TestFixture]
    public class FeedPage
    {
        [Test]
        public void ImageButton_Clicked()
        {
            var feedPage = new LifeofSi.FeedPage();
            feedPage.ImageButton_Clicked.Execute(null);
            Assert.AreEqual(Xplabel.Text = $"{clickTotal} /20", feedPage.Xplabel);
        }
    }
}
