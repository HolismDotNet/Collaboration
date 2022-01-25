namespace Collaboration;

public class CollaborationContext : DatabaseContext
{
    public override string ConnectionStringName => "Collaboration";

    public DbSet<Collaboration.Invitation> Invitations { get; set; }

    public DbSet<Collaboration.InvitationView> InvitationViews { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
