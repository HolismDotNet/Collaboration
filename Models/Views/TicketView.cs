using System;

namespace Holism.Collaboration.Models
{
    public class TicketView : Holism.Models.IEntity
    {
        public TicketView()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid UserGuid { get; set; }

        public string User { get; set; }

        public string Title { get; set; }

        public DateTime UtcDate { get; set; }

        public long PriorityId { get; set; }

        public string PriorityKey { get; set; }

        public long StateId { get; set; }

        public string StateKey { get; set; }

        public DateTime? LatestPostUtcDate { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
