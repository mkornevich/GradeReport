using GradeReport.Common.NotificationNS;
using GradeReport.ProjectNS;
using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Validation.Validators
{
    public class GroupValidator : Validator
    {
        protected override void ValidateHandler(Project project, Entity entity, NotificationFormBuilder builder, object[] args)
        {
            var group = (Group)entity;
            builder.ErrorIf(group.Name == "", "Название не должно быть пустым.");
            builder.ErrorIf(project.Groups.Exists(g => g.Name == group.Name && g.Guid != group.Guid), "Название должно быть уникальным.");
        }

        protected override void CanRemoveHandler(Project project, Entity entity, NotificationFormBuilder builder, object[] args)
        {
            var group = (Group)entity;
            builder.ErrorIf(
                project.Config.CuratorGroupGuid == group.Guid ||
                project.GroupSubjectRefs.Exists(gsr => gsr.GroupGuid == group.Guid) ||
                project.Courses.Exists(c => c.GroupGuid == group.Guid) ||
                project.Students.Exists(s => s.GroupGuid == group.Guid), 
                "Невозможно удалить группу так как на нее ссылаются другие объекты.",
                "Причины возникновения:\n" +
                "1) В конфигурации данная группа указана как группа куратора.\n" +
                "2) Для данной группы не все предметы удалены.\n" +
                "3) Для данной группы не все курсы удалены\n" +
                "4) Для данной группы не все студенты удалены\n");
        }
    }
}
