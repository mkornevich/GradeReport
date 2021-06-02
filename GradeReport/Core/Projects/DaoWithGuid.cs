using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Core.Projects
{
    public class DaoWithGuid<TEntity> : Dao<TEntity> where TEntity : EntityWithGuid
    {
        public TEntity GetByGuid(Guid guid) => Find(e => e.Guid == guid);
    }
}
