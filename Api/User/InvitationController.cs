namespace Holism.Collaboration.UserApi;

public class InvitationController : Controller<InvitationView, Invitation>
{
    public override ReadBusiness<InvitationView> ReadBusiness => new InvitationBusiness();

    public override Business<InvitationView, Invitation> Business => new InvitationBusiness();
    
    public override Action<Invitation, UpsertMode> PreUpsertion => (invitation, upsertMode) => 
    {
        new OwnerBusiness().EnsureOwns(UserGuid, invitation.SalonGuid);
        if (upsertMode == UpsertMode.Creation)
        {
            invitation.InvitingUserGuid = UserGuid;
        }
    };
}