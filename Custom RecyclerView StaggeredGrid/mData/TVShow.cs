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

namespace Custom_RecyclerView_StaggeredGrid.mData
{
    class TVShow
    {
        private String name;
        private int image;

        public TVShow()
        {
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}