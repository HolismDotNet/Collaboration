namespace Holism.Collaboration.Models;

public class Invitation : IGuidEntity
{
    public Invitation()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid Guid { get; set; }

    public Guid InvitingUserGuid { get; set; }

    public string InvitedEmail { get; set; }

    public DateTime UtcDate { get; set; }

    public dynamic RelatedItems { get; set; }
}
