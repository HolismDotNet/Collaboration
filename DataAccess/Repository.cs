namespace Holism.Collaboration.DataAccess;

public class Repository
{
    public static Repository<AttachedFile> AttachedFile
    {
        get
        {
            return new Repository<AttachedFile>(new CollaborationContext());
        }
    }

    public static Repository<PostHtml> PostHtml
    {
        get
        {
            return new Repository<PostHtml>(new CollaborationContext());
        }
    }

    public static Repository<Post> Post
    {
        get
        {
            return new Repository<Post>(new CollaborationContext());
        }
    }

    public static Repository<Ticket> Ticket
    {
        get
        {
            return new Repository<Ticket>(new CollaborationContext());
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
