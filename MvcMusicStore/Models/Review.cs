using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MvcMusicStore.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int AlbumID { get; set; }
        public virtual Album Album { get; set; }
        public string Contents { get; set; }

        [Required()]
        [Display(Name="Email Address")]//It changes the name showing in the view, it will show Email Address instead of ReviewerEmail
        [DataType(DataType.EmailAddress)]//This tells to the browser that ReviewerEmail is a type of Email so that way it will use the property type="email" in the HTML
        public string ReviewerEmail { get; set; }

    }
}
