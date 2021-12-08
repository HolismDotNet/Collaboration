using System;

namespace Holism.Collaboration.Models
{
    public class AttachedFile : Holism.Models.IEntity
    {
        public AttachedFile()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public long PostId { get; set; }

        public Guid FileGuid { get; set; }

        public string FileExtension { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
