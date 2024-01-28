using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TFA.Storage
{
    public class Forum
    {
        [Key]
        public Guid ForumId {get; set;}
        public string Title {get; set;}
        [InverseProperty(nameof(Topic.Forum))]
        public ICollection<Topic> Topics {get; set;}
    }
}