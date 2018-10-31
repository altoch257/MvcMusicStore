﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Genre
    {
        public virtual int GenreID { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}