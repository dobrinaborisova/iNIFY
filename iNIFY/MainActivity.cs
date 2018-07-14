using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;

namespace iNIFY
{
    [Activity(Label = "MainActivity", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button plusButton;
        private Button minusButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            FindViews();
            HandleEvents();
        }

        private void FindViews()
        {
            plusButton = FindViewById<Button>(Resource.Id.buttonPlus);
            minusButton = FindViewById<Button>(Resource.Id.buttonMinus);
        }

        private void HandleEvents()
        {
            plusButton.Click += PlusButton_Click;
            minusButton.Click += MinusButton_Click;
        }

        private void PlusButton_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(CalculatorActivity2));
            StartActivity(intent);
        }

        private void MinusButton_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(CalculatorActivity));
            StartActivity(intent);
        }
    }
}

