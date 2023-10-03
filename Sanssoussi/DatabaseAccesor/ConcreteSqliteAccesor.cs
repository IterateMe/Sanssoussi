using Microsoft.EntityFrameworkCore;
using Sanssoussi.Areas.Identity.Data;
using Sanssoussi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sanssoussi.DatabaseAccesor
{
    public class ConcreteSqliteAccesor :  IDatabaseAccessor
    {
        private readonly SanssoussiApplicationDataContext _context;
        
        public ConcreteSqliteAccesor(SanssoussiApplicationDataContext context) =>_context = context;

        /// <summary>
        /// Get all the emails for a given user
        /// </summary>
        /// <returns></returns>
        public IReadOnlyList<CommentModel> GetComments(SanssoussiUser user)
        {
           return _context.comments.Where(comment => comment.UserId == user.Id).ToList();
        }

        /// <summary>
        /// Get all the emails in the AspUserTable
        /// </summary>
        /// <returns></returns>
        public IReadOnlyList<string> GetEmails()
        {
           return _context.users.Select(u => u.Email).ToList();
        }

        /// <summary>
        /// Post new comments
        /// </summary>
        /// <returns></returns>
        public bool PostComments(CommentModel comments)
        {
            _context.comments.Add(comments);
            return _context.SaveChanges() ==1; 
        }

        /// <summary>
        /// Search comments for a given user containing the reasearch data specified
        /// </summary>
        /// <returns></returns>
        public IReadOnlyList<CommentModel> SearchComment(SanssoussiUser user, string sanitizedSearchData)
        {
            return _context.comments
                .Where(comment => (comment.UserId == user.Id) && (comment.Comment.Contains(sanitizedSearchData))).ToList() ;
        }
    }
}
