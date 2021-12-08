using Holism.Api;
using Holism.Business;
using Holism.Collaboration.Business;
using Holism.Collaboration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Holism.Collaboration.AdminApi
{
    public class TicketController : Controller<TicketView, Ticket>
    {
        public override ReadBusiness<TicketView> ReadBusiness => new TicketBusiness();
        
        public override Business<TicketView, Ticket> Business => new TicketBusiness();
    }
}
