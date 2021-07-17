using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS
{
    public class Dao<TEntity> : List<TEntity> where TEntity : Entity
    {

    }
}
