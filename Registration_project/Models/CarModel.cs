﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration_project.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? BrandId { get; set; }
        public CarBrand CarBrand { get; set; }
        
    }
}