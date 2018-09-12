using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using Android.Content;

namespace WishList
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : ListActivity
    {
        string[] wishList = new string[5];
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);                       
            wishList[0] = "Porsche";
            wishList[1] = "Xbox One X";
            wishList[2] = "Gaming Keyboard";
            wishList[3] = "Monitor";
            wishList[4] = "Australian Vacation";
            
            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, wishList);            
        }
        
        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);
            Intent secondActivity = new Intent(this, typeof(SecondActivity));
            string item = wishList[position];
            Toast.MakeText(this, "They clicked: " + item, ToastLength.Long).Show();

            if (position == 0)
            {
                secondActivity.PutExtra("wish","porsche");
                secondActivity.PutExtra("url", "https://www.porsche.com/usa/models/718/718-gts-models/");
                StartActivity(secondActivity);
            }else if (position == 1)
            {
                secondActivity.PutExtra("wish", "xbox");
                secondActivity.PutExtra("url", "https://www.xbox.com/en-US/xbox-one-x?xr=shellnav");
                StartActivity(secondActivity);
            }
            else if (position == 2)
            {
                secondActivity.PutExtra("wish", "keyboard");
                secondActivity.PutExtra("url", "https://www.bestbuy.com/site/razer-blackwidow-chroma-v2-wired-gaming-mechanical-green-switch-keyboard-with-rgb-back-lighting-black/5588907.p?skuId=5588907");
                StartActivity(secondActivity);
            }
            else if (position == 3)
            {
                secondActivity.PutExtra("wish", "monitor");
                secondActivity.PutExtra("url", "https://www.bestbuy.com/site/dell-27-led-qhd-gsync-monitor-black/5293502.p?skuId=5293502");
                StartActivity(secondActivity);
            }
            else if (position == 4)
            {
                secondActivity.PutExtra("wish", "australia");
                secondActivity.PutExtra("url", "https://www.tripadvisor.com/Vacation_Packages-g255066-Darwin_Top_End_Northern_Territory-Vacations.html");
                StartActivity(secondActivity);
            }
        }
    }
}