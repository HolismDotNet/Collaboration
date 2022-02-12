namespace Collaboration;

public class InvitationBusiness : Business<InvitationView, Invitation>
{
    protected override Write<Invitation> Write => Repository.Invitation;

    protected override Read<InvitationView> Read => Repository.InvitationView;

    protected override void PreCreation(Invitation invitation)
    {
        invitation.UtcDate = UniversalDateTime.Now;
    }
}