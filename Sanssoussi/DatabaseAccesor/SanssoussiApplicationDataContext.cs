using Microsoft.EntityFrameworkCore;
using Sanssoussi.Areas.Identity.Data;
using Sanssoussi.Models;

namespace Sanssoussi.DatabaseAccesor
{
    public class SanssoussiApplicationDataContext :DbContext
    {
        public SanssoussiApplicationDataContext(DbContextOptions<SanssoussiApplicationDataContext> options)
        : base(options)
        {
        }

        public DbSet<CommentModel> comments { get; set; }
        public DbSet<SanssoussiUser > users { get; set; }
    }
}
