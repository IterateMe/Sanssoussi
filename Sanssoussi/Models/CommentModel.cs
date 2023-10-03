using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace Sanssoussi.Models
{
    public class CommentModel
    {
        [Key]
        public string CommentId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string Comment { get; set; }


        public CommentModel(string commentId, string userId, string comment)
        {
            CommentId = commentId;
            UserId = userId;
            Comment = comment;
        }
    }
}
