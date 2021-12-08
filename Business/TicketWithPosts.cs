using System.Collections.Generic;
using Holism.Collaboration.Models;

namespace Holism.Collaboration.Business
{
    public class TicketWithPosts
    {
        public TicketView Ticket { get; set; }

        public List<Post> Posts { get; set; }
    }
}