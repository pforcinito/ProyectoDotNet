using System;
using System.Collections.Generic;

#nullable disable

namespace MyServiceWeb.Models
{
    public partial class RequestRelationship
    {
        public long IdRequest { get; set; }
        public long IdUserReceive { get; set; }
        public long IdUserSend { get; set; }
        public bool State { get; set; }

        public virtual User IdUserReceiveNavigation { get; set; }
        public virtual User IdUserSendNavigation { get; set; }
    }
}
