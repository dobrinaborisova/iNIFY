package md5c886a9dc524165e8b186da2bc556f214;


public class CalculatorActivity2
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("iNIFY.CalculatorActivity2, iNIFY", CalculatorActivity2.class, __md_methods);
	}


	public CalculatorActivity2 ()
	{
		super ();
		if (getClass () == CalculatorActivity2.class)
			mono.android.TypeManager.Activate ("iNIFY.CalculatorActivity2, iNIFY", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
