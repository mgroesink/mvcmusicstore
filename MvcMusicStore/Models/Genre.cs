﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Display(Name="Genre")]
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Album> Albums { get; set; }
    }
}