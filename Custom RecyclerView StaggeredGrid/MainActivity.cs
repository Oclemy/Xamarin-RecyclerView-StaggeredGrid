using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using Custom_RecyclerView_StaggeredGrid.mData;
using Custom_RecyclerView_StaggeredGrid.mRecycler;

namespace Custom_RecyclerView_StaggeredGrid
{
    [Activity(Label = "Custom_StaggeredGrid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private RecyclerView rv;
        private MyAdapter adapter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            //RV
            rv = FindViewById<RecyclerView>(Resource.Id.mRecylcerID);
            rv.SetLayoutManager(new StaggeredGridLayoutManager(2,1));
            rv.SetItemAnimator(new DefaultItemAnimator());

            //ADAPTER
            adapter = new MyAdapter(TVShowsCollection.getTVShows());
            rv.SetAdapter(adapter);

            adapter.ItemClick += onItemClick;
        }

        void onItemClick(object sender, int position)
        {
            Toast.MakeText(this, TVShowsCollection.getTVShows()[position].Name, ToastLength.Short).Show();
        }
    }
}

