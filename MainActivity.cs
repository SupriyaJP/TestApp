using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace Switch_Activity
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            var edtName = FindViewById<EditText>(Resource.Id.edtName);
            var edtPassword = FindViewById<EditText>(Resource.Id.edtPassword);
            var btnSend = FindViewById<Button>(Resource.Id.sendbtn);
            btnSend.Click += (s, e) =>
              {
                  Intent nextActivity = new Intent(this, typeof(NextPage));
                  nextActivity.PutExtra("name", edtName.Text);
                  nextActivity.PutExtra("email", edtPassword.Text);
                  StartActivity(nextActivity);
              };


        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}