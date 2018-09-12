using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WishList
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Android.App.Activity
    {
        Button btnViewMore, btnGoBack;
        string wish, url;
        ImageView imgViewWish;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_second);
            btnViewMore = FindViewById<Button>(Resource.Id.btnViewMore);
            btnViewMore.Click += BtnViewMore_Click;
            wish = Intent.GetStringExtra("wish") ?? "Not Recv";
            url = Intent.GetStringExtra("url") ?? "https://www.google.com/webhp?hl=en&sa=X&ved=0ahUKEwiQ3LO3prbdAhVVIzQIHdUZDGsQPAgD";
            imgViewWish = FindViewById<ImageView>(Resource.Id.imgViewWish);
            btnGoBack = FindViewById<Button>(Resource.Id.btnGoBack);
            findImage();
            btnGoBack.Click += delegate
            {
                this.Finish();
            };

        }

        private void findImage()
        {
            if (wish == "porsche")
            {
                imgViewWish.SetImageResource(Resource.Drawable.porsche);
            }
            else if (wish == "xbox")
            {
                imgViewWish.SetImageResource(Resource.Drawable.xbox);
            }
            else if (wish == "keyboard")
            {
                imgViewWish.SetImageResource(Resource.Drawable.keyboard);
            }
            else if (wish == "monitor")
            {
                imgViewWish.SetImageResource(Resource.Drawable.monitor);
            }
            else if (wish == "australia")
            {
                imgViewWish.SetImageResource(Resource.Drawable.australia);
            }
        }


        private void BtnViewMore_Click(object sender, EventArgs e)        
        {            
            var uri = Android.Net.Uri.Parse(url);
            var intent = new Intent(Intent.ActionView, uri);
            if (wish == "porsche")
            {                          
                StartActivity(intent);
            }
            else if (wish == "xbox")
            {
                StartActivity(intent);
            }
            else if (wish == "keyboard")
            {
                StartActivity(intent);
            }
            else if (wish == "monitor")
            {
                StartActivity(intent);
            }
            else if (wish == "australia")
            {
                StartActivity(intent);
            }

        }

        
    }
    
}