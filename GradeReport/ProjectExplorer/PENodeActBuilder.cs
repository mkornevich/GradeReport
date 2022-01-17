using GradeReport.Edit;
using GradeReport.ProjectModel;
using GradeReport.ProjectModel.Entities;
using GradeReport.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ProjectExplorer
{
    public static class PENodeActBuilder
    {
        public static EventHandler BuildEditAct(PENode node, Entity entityTemp, EditForm editForm, Validator validator)
        {
            return (s, e) =>
            {
                editForm.Project = node.Project;

                node.Entity.CopyTo(entityTemp);

                if (editForm.ShowForResult(entityTemp, validator, ChangeMode.Edit) == DialogResult.OK)
                {
                    entityTemp.CopyTo(node.Entity);
                    node.Project.OnChanged();
                }
            };
        }

        public static EventHandler BuildCreateAct<TEntity>(PENode node, EntityCollection<TEntity> entityDao, EditForm editForm, Validator validator) where TEntity : Entity
        {
            return BuildCreateAct(node, () => entityDao.Create(), (e) => entityDao.Add((TEntity)e), editForm, validator);
        }

        public static EventHandler BuildCreateAct(PENode node, Func<Entity> createEntityFunc, Action<Entity> addEntityAction, EditForm editForm, Validator validator)
        {
            return (s, e) =>
            {
                if (validator.CanCreate(node.Project))
                {
                    editForm.Project = node.Project;

                    var entity = createEntityFunc();

                    if (editForm.ShowForResult(entity, validator, ChangeMode.Create) == DialogResult.OK)
                    {
                        addEntityAction(entity);
                        node.Project.OnChanged();
                    }
                }
            };
        }

        public static EventHandler BuildRemoveAct<TEntity>(PENode node, EntityCollection<TEntity> dao, Validator validator) where TEntity : Entity
        {
            return (s, e) =>
            {
                if (validator.CanRemove(node.Project, node.Entity))
                {
                    dao.Remove((TEntity)node.Entity);
                    node.Project.OnChanged();
                }
            };
        }
    }
}
