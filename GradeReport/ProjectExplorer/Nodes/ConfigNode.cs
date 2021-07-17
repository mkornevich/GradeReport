﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectExplorer.Nodes
{
    public class ConfigNode : PENode
    {
        public override string Description => "Данный узел представляет конфигурацию текущего проекта. Редактировать можно через ПКМ.";

        protected override void Visualize()
        {
            Text = "Конфигурация";
        }
    }
}