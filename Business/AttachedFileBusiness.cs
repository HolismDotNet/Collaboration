using Holism.Business;
using Holism.DataAccess;
using Holism.Collaboration.DataAccess;
using Holism.Collaboration.Models;

namespace Holism.Collaboration.Business
{
    public class AttachedFileBusiness : Business<AttachedFile, AttachedFile>
    {
        protected override Repository<AttachedFile> WriteRepository => Repository.AttachedFile;

        protected override ReadRepository<AttachedFile> ReadRepository => Repository.AttachedFile;

    }
}
