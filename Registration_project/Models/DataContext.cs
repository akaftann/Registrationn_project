using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Registration_project.Models
{
    public class DataContext:DbContext
    {
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }
      
    }
}