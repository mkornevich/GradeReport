﻿using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectExplorer.Nodes
{
    public class GroupSubjectRefNode : PENode
    {
        public override string Description => "Данный узел представляет предмет который привязан к группе из узла выше.";

        protected override void Visualize()
        {
            var subject = Project.Subjects.Find(s => s.Guid == ((GroupSubjectRef)Object).SubjectGuid);
            Text = subject.ShortName;
        }

        protected override bool EqualsForFresh(PENode node)
        {
            return base.EqualsForFresh(node) && 
                ((GroupSubjectRef)Object).GroupGuid == ((GroupSubjectRef)node.Object).GroupGuid &&
                ((GroupSubjectRef)Object).SubjectGuid == ((GroupSubjectRef)node.Object).SubjectGuid;
        }
    }
}