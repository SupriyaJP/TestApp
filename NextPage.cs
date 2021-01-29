using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Switch_Activity
{
    [Activity(Label = "NextPage")]
    public class NextPage : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.nextpage);
            string name = Intent.GetStringExtra("name" ?? "Not recieved");
            string email = Intent.GetStringExtra("email" ?? "Not recieved");
            var txtName = FindViewById<TextView>(Resource.Id.textn);
            var txtPwd = FindViewById<TextView>(Resource.Id.texte);
            txtName.Text = name;
            txtPwd.Text = email;
        }
    }
}