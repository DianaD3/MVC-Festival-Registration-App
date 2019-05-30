using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Festivals.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public virtual ICollection<Desfasurator> Desfasurator { get; set; }
    }
}