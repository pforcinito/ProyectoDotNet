using System;
using System.Collections.Generic;

#nullable disable

namespace MyServiceWeb.Models
{
    public partial class UserPost
    {
        public UserPost()
        {
            Images = new HashSet<Image>();
        }

        public long IdPublication { get; set; }
        public long IdUser { get; set; }
        public DateTime DatePublication { get; set; }
        public string Post { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
