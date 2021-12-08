using System.Collections.Generic;
using Holism.Collaboration.Models;
using Holism.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Holism.Collaboration.DataAccess
{
    public class CollaborationContext : DatabaseContext
    {
        public override string ConnectionStringName => "Collaboration";

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<PostHtml> PostHtmls { get; set; }

        public DbSet<AttachedFile> AttachedFiles { get; set; }

        public DbSet<TicketView> TicketViews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
