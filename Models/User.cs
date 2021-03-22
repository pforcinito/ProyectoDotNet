using System;
using System.Collections.Generic;

#nullable disable

namespace MyServiceWeb.Models
{
    public partial class User
    {
        public User()
        {
            RequestRelationshipIdUserReceiveNavigations = new HashSet<RequestRelationship>();
            RequestRelationshipIdUserSendNavigations = new HashSet<RequestRelationship>();
            UserPosts = new HashSet<UserPost>();
        }

        public long IdUser { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public DateTime Birthday { get; set; }
        public int AttemptLogin { get; set; }
        public bool LogIn { get; set; }
        public bool Locked { get; set; }

        public virtual ICollection<RequestRelationship> RequestRelationshipIdUserReceiveNavigations { get; set; }
        public virtual ICollection<RequestRelationship> RequestRelationshipIdUserSendNavigations { get; set; }
        public virtual ICollection<UserPost> UserPosts { get; set; }
    }
}
