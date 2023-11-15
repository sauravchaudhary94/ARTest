using ARTest.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(BaseUrl))]
namespace ARTest.UWP
{
    internal class BaseUrl : IBaseUrl
    {
        public string GetUrl()
        {
            return "ms-appx-web:///";
        }
    }
}
