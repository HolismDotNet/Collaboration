namespace Holism.Collaboration.Models;

public class InvitationView : IEntity
{
    public InvitationView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Temp { get; set; }

    public dynamic RelatedItems { get; set; }
}
