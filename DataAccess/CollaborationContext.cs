namespace Holism.Collaboration.DataAccess;

public class CollaborationContext : DatabaseContext
{
    public override string ConnectionStringName => "Collaboration";

    public DbSet<AttachedFile> AttachedFiles { get; set; }

    public DbSet<PostHtml> PostHtmls { get; set; }

    public DbSet<Post> Posts { get; set; }

    public DbSet<Ticket> Tickets { get; set; }

    public DbSet<TicketView> TicketViews { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
