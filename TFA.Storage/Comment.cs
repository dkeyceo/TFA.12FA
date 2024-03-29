using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TFA.Storage
{
    public class Comment
    {
        [Key]
        public Guid CommentId {get; set;}
        public DateTimeOffset CreatedAt {get; set;}
        public DateTimeOffset? UpdatedAt {get; set;}

        public Guid TopicId {get; set;}
        
        public Guid UserId {get; set;}
        
        [ForeignKey(nameof(UserId))]
        public User Author {get; set;}
        
        [ForeignKey(nameof(TopicId))]
        public Topic Topic {get; set;}

        public string Text {get; set;}


    }
}