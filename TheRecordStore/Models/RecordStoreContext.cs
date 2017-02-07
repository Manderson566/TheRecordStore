using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TheRecordStore.Models
{
    public class RecordStoreContext : DbContext
    {
       public DbSet<Band> Bands { get; set; }
    }
}