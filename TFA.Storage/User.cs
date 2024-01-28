using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TFA.Storage
{
    public class User
    {
        [Key]
        public Guid UserId {get; set;}

        [MaxLength(20)]
        public string Login {get; set;}
        [InverseProperty(nameof(Topic.Author))]
        public ICollection<Topic> Topics {get; set;}
        [InverseProperty(nameof(Comment.Author))]
        public ICollection<Comment> Comments {get; set;}

    }
}