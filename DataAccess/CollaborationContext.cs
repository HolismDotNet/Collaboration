namespace Holism.Collaboration.DataAccess;

public class CollaborationContext : DatabaseContext
{
    public override string ConnectionStringName => "Collaboration";

    public DbSet<Invitation> Invitations { get; set; }

    public DbSet<TicketView> TicketViews { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
