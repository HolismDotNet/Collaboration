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

    public static Repository<TicketView> TicketView
    {
        get
        {
            return new Repository<TicketView>(new CollaborationContext());
        }
    }
}
