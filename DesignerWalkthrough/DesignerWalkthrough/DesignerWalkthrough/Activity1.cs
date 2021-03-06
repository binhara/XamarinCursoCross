using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DesignerWalkthrough
{
    [Activity (Label = "DesignerWalkthrough", MainLauncher = true)]
    public class Activity1 : Activity
    {

        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            
            var contactsAdapter = new ContactsAdapter (this);       
            var contactsListView = FindViewById<ListView> (Resource.Id.contactsListView);      
            contactsListView.Adapter = contactsAdapter;
        }
    }
}


