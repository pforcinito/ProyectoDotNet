using System;
using System.Collections.Generic;

#nullable disable

namespace MyServiceWeb.Models
{
    public partial class Image
    {
        public long IdImage { get; set; }
        public long IdPublication { get; set; }
        public byte[] Image1 { get; set; }

        public virtual UserPost IdPublicationNavigation { get; set; }
    }
}
