using Holism.Api;
using Holism.Business;
using Holism.Collaboration.Business;
using Holism.Collaboration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Holism.Collaboration.UserApi
{
    public class CollaborationStateController : EnumController<State>
    {
        public override EnumBusiness<State> EnumBusiness => new StateBusiness();
    }
}
