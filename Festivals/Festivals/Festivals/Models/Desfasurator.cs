using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Festivals.Models
{

    public class Desfasurator
    {
        public int DesfasuratorID { get; set; }
        public int FestivalID { get; set; }
        public int ArtistID { get; set; }
        // public string Name { get; set; }
        // public string NameFestival { get; set; }
        public virtual Festival Festival { get; set; }
        public virtual Artist Artist { get; set; }
    }
}