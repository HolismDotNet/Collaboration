namespace Collaboration;

public class CollaborationContext : DatabaseContext
{
    public override string ConnectionStringName => "Collaboration";

    public DbSet<Invitation> Invitations { get; set; }

    public DbSet<InvitationView> InvitationViews { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
