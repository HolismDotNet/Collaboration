using Holism.Collaboration.Models;
using Holism.DataAccess;

namespace Holism.Collaboration.DataAccess
{
    public class Repository
    {
        public static Repository<Ticket> Ticket
        {
            get
            {
                return new Holism.DataAccess.Repository<Ticket
                >(new CollaborationContext());
            }
        }

        public static Repository<Post> Post
        {
            get
            {
                return new Holism.DataAccess.Repository<Post
                >(new CollaborationContext());
            }
        }

        public static Repository<PostHtml> PostHtml
        {
            get
            {
                return new Holism.DataAccess.Repository<PostHtml
                >(new CollaborationContext());
            }
        }

        public static Repository<AttachedFile> AttachedFile
        {
            get
            {
                return new Holism.DataAccess.Repository<AttachedFile
                >(new CollaborationContext());
            }
        }

        public static Repository<TicketView> TicketView
        {
            get
            {
                return new Holism.DataAccess.Repository<TicketView
                >(new CollaborationContext());
            }
        }
    }
}
