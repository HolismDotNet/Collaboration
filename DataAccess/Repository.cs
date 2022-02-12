namespace Collaboration;

public class Repository
{
    public static Write<Collaboration.Invitation> Invitation
    {
        get
        {
            return new Write<Collaboration.Invitation>(new CollaborationContext());
        }
    }

    public static Write<Collaboration.InvitationView> InvitationView
    {
        get
        {
            return new Write<Collaboration.InvitationView>(new CollaborationContext());
        }
    }
}
