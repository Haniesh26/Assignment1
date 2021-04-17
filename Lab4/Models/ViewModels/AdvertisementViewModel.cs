﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Models.ViewModels
{
    public class AdvertisementViewModel
    {
        public Community Community { get; set; }
        public IEnumerable<Advertisement> Advertisements { get; set; }
    }
}
