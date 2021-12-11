using Holism.Collaboration.Models;
using Holism.Collaboration.DataAccess;

namespace Holism.Collaboration.Business;

public class InvitationBusiness : Business<Invitation, Invitation>
{
    protected override Repository<Invitation> WriteRepository =>
        Repository.Invitation;

    protected override ReadRepository<Invitation> ReadRepository =>
        Repository.Invitation;
}