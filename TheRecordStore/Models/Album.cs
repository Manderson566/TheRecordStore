using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheRecordStore.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string AlbumName { get; set; }
        public DateTime AlbumRelease { get; set; }
        public int BandId { get; set; }

        public virtual Band Band { get; set; }
    }
}