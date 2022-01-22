


namespace Holism.Collaboration.Business;

public class InvitationBusiness : Business<InvitationView, Invitation>
{
    protected override Repository<Invitation> WriteRepository =>
        Repository.Invitation;

    protected override ReadRepository<InvitationView> ReadRepository =>
        Repository.InvitationView;

    protected override void PreCreation(Invitation invitation)
    {
        invitation.UtcDate = UniversalDateTime.Now;
    }
}