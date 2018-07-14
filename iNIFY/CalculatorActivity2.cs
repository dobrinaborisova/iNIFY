using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Widget;

namespace iNIFY
{
    [Activity(Label = "CalculatorActivity2", Theme = "@style/AppTheme")]
    public class CalculatorActivity2 : Android.Support.V7.App.AppCompatActivity
    
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CalculatorConstrained);

        }
    }
}