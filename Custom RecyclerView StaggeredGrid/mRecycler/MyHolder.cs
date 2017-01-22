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

namespace Custom_RecyclerView_StaggeredGrid.mRecycler
{
    class MyHolder : RecyclerView.ViewHolder
    {
        public TextView NameTxt;
        public ImageView Img;
        private Action<int> listener;

        public MyHolder(View itemView, Action<int> listener)
            : base(itemView)
        {
            NameTxt = itemView.FindViewById<TextView>(Resource.Id.nameTxt);
            Img = itemView.FindViewById<ImageView>(Resource.Id.movieImage);
            this.listener = listener;

            itemView.Click += itemView_Click;
        }

        void itemView_Click(object sender, EventArgs e)
        {
            listener(this.LayoutPosition);
        }
    }
}