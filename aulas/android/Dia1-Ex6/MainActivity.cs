﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

// Dia 1 - Exemplo 6 List View - http://docs.xamarin.com/guides/android/user_interface/working_with_listviews_and_adapters

namespace Dia1Ex6
{
	[Activity (Label = "Dia1-Ex6", MainLauncher = true)]
	public class MainActivity: ListActivity 
	{
		string[] items;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			items = new string[] { "Vegetais","Frutas","Flores","Legumes","Bulbos","Tubérculos",
				"Carne bovina", "Aves", "Peixes", "Répteis", "Massas", "Sushis", "Sashimis"};
			ListAdapter = new CustomAdapter(this, Android.Resource.Layout.SimpleListItem1, items);

			ListView.FastScrollEnabled = true;
		}

		protected override void OnListItemClick(ListView l, View v, int position, long id)
		{
			var t = items[position];
			Android.Widget.Toast.MakeText(this, t, Android.Widget.ToastLength.Short).Show();

		}

		public override bool OnCreateOptionsMenu (IMenu menu)
		{
			MenuInflater.Inflate(Resource.Menu.application_menu, menu);
			return true;
		}

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			switch (item.ItemId) {
			case Resource.Id.simple:
				ListAdapter = new CustomAdapter(this, Android.Resource.Layout.SimpleListItem1, items);
				return true;
			case Resource.Id.with_heading:
				ListAdapter = new CustomAdapter(this, Android.Resource.Layout.SimpleListItem2, items);
				return true;
			case Resource.Id.two_lines:
				ListAdapter = new CustomAdapter(this, Android.Resource.Layout.TwoLineListItem, items);
				return true;
			case Resource.Id.activity:
				ListAdapter = new CustomAdapter(this, Android.Resource.Layout.ActivityListItem, items);
				return true;
			case Resource.Id.checks:
				ListAdapter = new CustomAdapter(this, Android.Resource.Layout.SimpleListItemChecked, items);
				ListView.ChoiceMode = ChoiceMode.Multiple;
				return true;
			case Resource.Id.single_choice:
				ListAdapter = new CustomAdapter(this, Android.Resource.Layout.SimpleListItemSingleChoice, items);
				ListView.ChoiceMode = ChoiceMode.Single;
				return true;			
			case Resource.Id.multiple_choice:
				ListAdapter = new CustomAdapter(this, Android.Resource.Layout.SimpleListItemMultipleChoice, items);
				ListView.ChoiceMode = ChoiceMode.Multiple;
				return true;
			default:
				return base.OnOptionsItemSelected (item);
			}
		}
	}
}


