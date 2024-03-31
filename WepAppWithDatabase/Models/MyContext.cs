using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace WepAppWithDatabase.Models
{
    public class MyContext :DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
    }
}