using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Custom_RecyclerView_StaggeredGrid.mData;

namespace Custom_RecyclerView_StaggeredGrid.mRecycler
{
    class MyAdapter : RecyclerView.Adapter
    {
        private JavaList<TVShow> tvShows;
        public event EventHandler<int> ItemClick;

        public MyAdapter(JavaList<TVShow> tvShows)
        {
            this.tvShows = tvShows;
        }

        //BIND DATA TO VIEWS
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            MyHolder h = holder as MyHolder;
            h.NameTxt.Text = tvShows[position].Name;
            h.Img.SetImageResource(tvShows[position].Image);

        }

        //INITIALIZE VH
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            //INFLATE LAYOUT TO VIEW
            View v = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.Model, parent, false);
            MyHolder holder = new MyHolder(v, onClick);

            return holder;
        }

        //TOTAL NUM OF TVSHOWS
        public override int ItemCount
        {
            get { return tvShows.Size(); }
        }
        void onClick(int position)
        {
            if (ItemClick != null)
            {
                ItemClick(this, position);
            }
        }
    }
}