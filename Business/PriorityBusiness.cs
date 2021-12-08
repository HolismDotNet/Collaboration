using Holism.Business;
using Holism.Collaboration.DataAccess;
using Holism.Collaboration.Models;

namespace Holism.Collaboration.Business
{
    public class PriorityBusiness : EnumBusiness<Priority>
    {
        public override string ConnectionString =>
            Repository.Ticket.ConnectionString;
    }
}
