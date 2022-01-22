namespace Collaboration;

public class Repository
{
    public static Repository<Collaboration.Invitation> Invitation
    {
        get
        {
            return new Repository<Collaboration.Invitation>(new CollaborationContext());
        }
    }

    public static Repository<Collaboration.InvitationView> InvitationView
    {
        get
        {
            return new Repository<Collaboration.InvitationView>(new CollaborationContext());
        }
    }
}
