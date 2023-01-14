using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_BaseRules.Domin;

namespace Music.Domin.MusicStyleAgg
{
    public class MusicStyle : BaseEntity
    {
        public string Name { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Title { get; private set; }

        public string Slug { get; private set; }
        public bool IsDelete { get; private set; }


        public MusicStyle(string name, string picture, string pictureAlt,
            string pictureTitle, string title, string slug)
        {
            Name = name;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Title = title;
            Slug = slug;
            IsDelete = false;
        }


        public void Edit(string name, string picture, string pictureAlt,
            string pictureTitle, string title, string slug)
        {
            Name = name;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Title = title;
            Slug = slug;
        }

        public void IsDeleted()
        {
            IsDelete = true;
        }

        public void IsRestore()
        {
            IsDelete = false;
        }


    }
}
