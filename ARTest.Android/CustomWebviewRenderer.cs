using Android.App;
using Android.Content;
using Android.Webkit;
using ARTest;
using ARTest.Droid;
using System.Net;
using System.Runtime.Remoting.Contexts;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]

namespace ARTest.Droid
{
    public class CustomWebViewRenderer : WebViewRenderer
    {
        Activity mContext;
        public CustomWebViewRenderer(Android.Content.Context context) : base(context)
        {
            this.mContext = context as Activity;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // Enable JavaScript in the WebView
                Control.Settings.JavaScriptEnabled = true;
                Control.Settings.AllowFileAccess = true;
                Control.Settings.AllowContentAccess = true;
                Control.Settings.AllowFileAccessFromFileURLs = true;
                Control.Settings.AllowUniversalAccessFromFileURLs = true;
                Control.SetWebChromeClient(new CustomWebViewClient(mContext));
                Control.Settings.MediaPlaybackRequiresUserGesture = false;
            }
        }
        // Override WebViewClient to handle permissions
    }

    public class CustomWebViewClient : WebChromeClient
    {
        Activity mContext;
       public CustomWebViewClient(Activity context)
        {
            this.mContext = context;
        } 
        public override void OnPermissionRequest(PermissionRequest request)
        {
            mContext.RunOnUiThread(() => {
                request.Grant(request.GetResources());
            });
        }
    }
}