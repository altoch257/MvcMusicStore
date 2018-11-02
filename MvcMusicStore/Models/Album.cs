using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public virtual int AlbumID { get; set; }

        public virtual int GenreID { get; set; }

        public virtual int ArtistID { get; set; }

        [Required(ErrorMessage = "Are you gonna create an album with no Title? Seriously?")]
        public virtual string Title { get; set; }

        [Required(ErrorMessage = "A Price is required. Enter 0 if if free.")]
        public virtual decimal Price { get; set; }

        public virtual string AlbumArtUrl { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual Artist Artist { get; set; }
    }

}