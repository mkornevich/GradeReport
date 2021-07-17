using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS
{
    public class Dao<TEntity> : List<TEntity>, IProjectProperty where TEntity : Entity
    {
        public Project Project { get; set; }

        public TEntity Create()
        {
            var entity = (Entity)Activator.CreateInstance(typeof(TEntity));
            entity.Project = Project;
            return (TEntity)entity;
        }
    }
}
