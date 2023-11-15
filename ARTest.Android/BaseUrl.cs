using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ARTest.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(BaseUrl))]
namespace ARTest.Droid
{
    internal class BaseUrl : IBaseUrl
    {
        public string GetUrl()
        {
            return "file:///android_asset/";
        }
    }
}