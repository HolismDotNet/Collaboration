namespace Collaboration;

public class InvitationBusiness : Business<InvitationView, Invitation>
{
    protected override Repository<Invitation> WriteRepository => RepositoryInvitation;

    protected override ReadRepository<InvitationView> ReadRepository => RepositoryInvitationView;

    protected override void PreCreation(Invitation invitation)
    {
        invitation.UtcDate = UniversalDateTime.Now;
    }
}