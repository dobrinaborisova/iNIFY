using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Widget;

namespace iNIFY
{
    [Activity(Label = "CalculatorActivity", Theme = "@style/AppTheme")]
    public class CalculatorActivity : Activity
    {
        private Button clearButton;
        private Button backButton;
        private Button sevenButton;
        private Button eightButton;
        private Button devideButton;
        private Button nineButton;
        private Button fiveButton;
        private Button sixButton;
        private Button multiplyButton;
        private Button oneButton;
        private Button twoButton;
        private Button fourButton;
        private Button threeButton;
        private Button substractButton;
        private Button decimalButton;
        private Button zeroButton;
        private Button equalsButton;
        private Button addButton;
        //private Button addButton;
        private Button categoriesButton;
        private EditText textInputForMoney;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_calc);

            FindViews();
            HandleEvents();
            //textInputForMoney.Enabled = true;
        }

        private void FindViews()
        {
            //clearButton = FindViewById<Button>(Resource.Id.btnClear);
            //backButton = FindViewById<Button>(Resource.Id.btnBack);
            sevenButton = FindViewById<Button>(Resource.Id.btnSeven);
            eightButton = FindViewById<Button>(Resource.Id.btnEight);
            devideButton = FindViewById<Button>(Resource.Id.btnDivide);
            nineButton = FindViewById<Button>(Resource.Id.btnNine);
            fiveButton = FindViewById<Button>(Resource.Id.btnFive);
            fourButton = FindViewById<Button>(Resource.Id.btnFour);
            sixButton = FindViewById<Button>(Resource.Id.btnSix);
            multiplyButton = FindViewById<Button>(Resource.Id.btnMultiply);
            oneButton = FindViewById<Button>(Resource.Id.btnOne);
            twoButton = FindViewById<Button>(Resource.Id.btnTwo);
            threeButton = FindViewById<Button>(Resource.Id.btnThree);
            substractButton = FindViewById<Button>(Resource.Id.btnSubtract);
            decimalButton = FindViewById<Button>(Resource.Id.btnDecimal);
            zeroButton = FindViewById<Button>(Resource.Id.btnZero);
            equalsButton = FindViewById<Button>(Resource.Id.btnEquals);
            addButton = FindViewById<Button>(Resource.Id.btnAdd);
            textInputForMoney = FindViewById<EditText>(Resource.Id.textInputForMoney);
            categoriesButton = FindViewById<Button>(Resource.Id.btnCattegories);
        }

        private void HandleEvents()
        {
            //clearButton.Click += ClearButton_Click;
            //backButton.Click += BackButton_Click;
            sevenButton.Click += SevenButton_Click;
            fourButton.Click += FourButton_Click;
            eightButton.Click += EightButton_Click;
            devideButton.Click += DevideButton_Click;
            nineButton.Click += NineButton_Click;
            fiveButton.Click += FiveButton_Click;
            sixButton.Click += SixButton_Click;
            multiplyButton.Click += MultiplyButton_Click;
            oneButton.Click += OneButton_Click;
            twoButton.Click += TwoButton_Click;
            threeButton.Click += ThreeButton_Click;
            substractButton.Click += SubstractButton_Click;
            decimalButton.Click += DecimalButton_Click;
            zeroButton.Click += ZeroButton_Click;
            equalsButton.Click += EqualsButton_Click;
            addButton.Click += AddButton_Click;
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void EqualsButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void DecimalButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void SubstractButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void MultiplyButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void DevideButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void BackButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void PlusButton_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(CalculatorActivity));
            StartActivity(intent);
        }

        private void Operate(string text)
        {
            textInputForMoney.Text += text;
        }

        #region Numbers

        private void FourButton_Click(object sender, System.EventArgs e)
        {
            Operate("4");
        }

        private void ZeroButton_Click(object sender, System.EventArgs e)
        {
            Operate("0");
        }
        
        private void NineButton_Click(object sender, System.EventArgs e)
        {
            Operate("9");
        }

        private void EightButton_Click(object sender, System.EventArgs e)
        {
            Operate("8");
        }

        private void SevenButton_Click(object sender, System.EventArgs e)
        {
            Operate("7");
        }

        private void SixButton_Click(object sender, System.EventArgs e)
        {
            Operate("6");
        }

        private void FiveButton_Click(object sender, System.EventArgs e)
        {
            Operate("5");
        }

        private void ThreeButton_Click(object sender, System.EventArgs e)
        {
            Operate("3");
        }

        private void TwoButton_Click(object sender, System.EventArgs e)
        {
            Operate("2");
        }

        private void OneButton_Click(object sender, System.EventArgs e)
        {
            Operate("1");
        }
        #endregion
    }
}