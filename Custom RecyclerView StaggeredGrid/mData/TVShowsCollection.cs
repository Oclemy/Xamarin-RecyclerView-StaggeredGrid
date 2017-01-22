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
    class TVShowsCollection
    {
        public static JavaList<TVShow> getTVShows()
        {
            JavaList<TVShow> tvshows = new JavaList<TVShow>();
            TVShow tvShow = new TVShow();

            tvShow.Name = "BlackList";
            tvShow.Image = Resource.Drawable.red;
            tvshows.Add(tvShow);

            tvShow = new TVShow();
            tvShow.Name = "Breaking Bad";
            tvShow.Image = Resource.Drawable.breaking;
            tvshows.Add(tvShow);

            tvShow = new TVShow();
            tvShow.Name = "Fruits";
            tvShow.Image = Resource.Drawable.fruits;
            tvshows.Add(tvShow);

            tvShow = new TVShow();
            tvShow.Name = "Crisis";
            tvShow.Image = Resource.Drawable.crisis;
            tvshows.Add(tvShow);

            tvShow = new TVShow();
            tvShow.Name = "Game of Thrones";
            tvShow.Image = Resource.Drawable.thrones;
            tvshows.Add(tvShow);

            tvShow = new TVShow();
            tvShow.Name = "Black";
            tvShow.Image = Resource.Drawable.blacklist;
            tvshows.Add(tvShow);

            tvShow = new TVShow();
            tvShow.Name = "Ghost Rider";
            tvShow.Image = Resource.Drawable.rider;
            tvshows.Add(tvShow);

            tvShow = new TVShow();
            tvShow.Name = "Shutle Carrier";
            tvShow.Image = Resource.Drawable.shuttlecarrier;
            tvshows.Add(tvShow);

            tvShow = new TVShow();
            tvShow.Name = "Star Wars";
            tvShow.Image = Resource.Drawable.starwars;
            tvshows.Add(tvShow);


            return tvshows;

        }
    }
}