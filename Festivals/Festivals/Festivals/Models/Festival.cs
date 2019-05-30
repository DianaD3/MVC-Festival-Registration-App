using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Festivals.Models
{
    public class Festival
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FestivalID { get; set; }
        public string NameFestival { get; set; }
        public string Locatie { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        
        public virtual ICollection<Desfasurator> Desfasurator { get; set; }
       
    }
}