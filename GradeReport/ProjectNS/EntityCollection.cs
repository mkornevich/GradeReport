using GradeReport.ProjectNS.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS
{

    public class EntityCollection<TEntity> : List<TEntity>, IList<TEntity>, IProjectProperty where TEntity : Entity
    {
        [JsonIgnore]
        public Project Project { get; set; }

        public TEntity Create()
        {
            var entity = (Entity)Activator.CreateInstance(typeof(TEntity));
            entity.Project = Project;
            return (TEntity)entity;
        }

        public EntityCollection(Project project)
        {
            Project = project;
        }
    }
}
