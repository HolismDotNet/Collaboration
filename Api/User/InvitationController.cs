namespace Collaboration;

public class InvitationController : Controller<InvitationView, Invitation>
{
    public override ReadBusiness<InvitationView> ReadBusiness => new InvitationBusiness();

    public override Business<InvitationView, Invitation> Business => new InvitationBusiness();

    public static Action<Invitation, HttpContext> Validator;
    
    public override Action<Invitation, UpsertMode> PreUpsertion => (invitation, upsertMode) => 
    {
        invitation.InvitingUserGuid = UserGuid;
        Validator?.Invoke(invitation, HttpContext);
    };
}