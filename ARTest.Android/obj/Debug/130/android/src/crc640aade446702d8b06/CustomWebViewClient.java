package crc640aade446702d8b06;


public class CustomWebViewClient
	extends android.webkit.WebChromeClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPermissionRequest:(Landroid/webkit/PermissionRequest;)V:GetOnPermissionRequest_Landroid_webkit_PermissionRequest_Handler\n" +
			"";
		mono.android.Runtime.register ("ARTest.Droid.CustomWebViewClient, ARTest.Android", CustomWebViewClient.class, __md_methods);
	}


	public CustomWebViewClient ()
	{
		super ();
		if (getClass () == CustomWebViewClient.class) {
			mono.android.TypeManager.Activate ("ARTest.Droid.CustomWebViewClient, ARTest.Android", "", this, new java.lang.Object[] {  });
		}
	}

	public CustomWebViewClient (android.app.Activity p0)
	{
		super ();
		if (getClass () == CustomWebViewClient.class) {
			mono.android.TypeManager.Activate ("ARTest.Droid.CustomWebViewClient, ARTest.Android", "Android.App.Activity, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public void onPermissionRequest (android.webkit.PermissionRequest p0)
	{
		n_onPermissionRequest (p0);
	}

	private native void n_onPermissionRequest (android.webkit.PermissionRequest p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
