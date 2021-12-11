namespace Holism.Collaboration.DataAccess;

public class Repository
{
    public static Repository<Invitation> Invitation
    {
        get
        {
            return new Repository<Invitation>(new CollaborationContext());
        }
    }

    public static Repository<InvitationView> InvitationView
    {
        get
        {
            return new Repository<InvitationView>(new CollaborationContext());
        }
    }
}
