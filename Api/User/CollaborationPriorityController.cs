using Holism.Api;
using Holism.Business;
using Holism.Collaboration.Business;
using Holism.Collaboration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Holism.Collaboration.UserApi
{
    public class CollaborationPriorityController : EnumController<Priority>
    {
        public override EnumBusiness<Priority> EnumBusiness => new PriorityBusiness();
    }
}
