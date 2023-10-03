using Microsoft.EntityFrameworkCore;
using Sanssoussi.Areas.Identity.Data;
using Sanssoussi.Models;
using System.Collections.Generic;

namespace Sanssoussi.DatabaseAccesor
{
    public interface IDatabaseAccessor
    {
        public IReadOnlyList<CommentModel> GetComments(SanssoussiUser user);
        public bool PostComments(CommentModel comments);

        public IReadOnlyList<CommentModel> SearchComment(SanssoussiUser user, string sanitizedSearchData);

        public IReadOnlyList<string> GetEmails();
    }
}
