using NUnit.Framework;
using System;
using LifeofSi;
using Xamarin.Forms;

namespace UnitTests.PageModels
{
    public class CocoonPage
    {
        [Test]
        public void OnTapGestureRecognizerTapped()
        {
            var feedPage = new LifeofSi.CocoonPage();
            feedPage.OnTapGestureRecognizerTapped.Execute(null);
            Assert.AreEqual(tapCount = 2, CocoonPage.transformImage);
        }
    }
}
