using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheRecordStore.Models
{
    public class Band
    {
        public int Id { get; set; }
        public string BandName { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Details { get; set; }
        public DateTime Created { get; set; }
    }
}