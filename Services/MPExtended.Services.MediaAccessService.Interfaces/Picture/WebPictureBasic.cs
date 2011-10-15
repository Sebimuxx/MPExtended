﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MPExtended.Services.MediaAccessService.Interfaces.Shared;

namespace MPExtended.Services.MediaAccessService.Interfaces.Picture
{
    public class WebPictureBasic : WebMediaItem, ITitleSortable, IDateAddedSortable, IPictureDateTakenSortable
    {
        public WebPictureBasic()
        {
            DateTaken = new DateTime(1970, 1, 1);
            DateAdded = new DateTime(1970, 1, 1);
            Path = new List<string>();
        }

        public string Id { get; set; }
        public string CategoryId { get; set; }
        public string Title { get; set; }
        public DateTime DateTaken { get; set; }
        public IList<string> Path { get; set; }
        public DateTime DateAdded { get; set; }

        public WebMediaType Type
        {
            get
            {
                return WebMediaType.Picture;
            }
        }

        public override string ToString()
        {
            return Title;
        }
    }
}