using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ARTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            try
            {
                InitializeComponent();

                var htmlSource = new HtmlWebViewSource();

               htmlSource.Html = @"<html>
                                <head>
                                <link rel=""stylesheet"" href=""default.css"">
                                </head>
                                <body>
                                <h1>Xamarin.Forms</h1>
                                <p>The CSS and image are loaded from local files!</p>
                                <img src='XamarinLogo.png'/>
                                <p><a href=""ar.html"">next page</a></p>
                                </body>
                                </html>"; 

                htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().GetUrl();
                webView.Source = htmlSource;
                Content = webView;
               /* var urlSource = new HtmlWebViewSource();
                string baseUrl = DependencyService.Get<IBaseUrl>().GetUrl();
                string filePathUrl = Path.Combine(baseUrl, "ar.html");
                urlSource.BaseUrl = filePathUrl;
                webView.Source = urlSource; */
            }
            catch(Exception ex)
            {

            }

        }

        async void OnBackButtonClicked(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
            else
            {
                await Navigation.PopAsync();
            }
        }

        void OnForwardButtonClicked(object sender, EventArgs e)
        {
            if (webView.CanGoForward)
            {
                webView.GoForward();
            }
        }
    }
}
