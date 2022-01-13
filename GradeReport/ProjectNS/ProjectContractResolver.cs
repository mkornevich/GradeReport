using GradeReport.ProjectNS.Entities;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ProjectNS
{
    public class ProjectContractResolver : DefaultContractResolver
    {
        private Project _project;

        private readonly Type projectType = typeof(Project);

        private readonly Type iProjectPropertyType = typeof(IProjectProperty);

        protected override JsonContract CreateContract(Type objectType)
        {
            JsonContract contract = base.CreateContract(objectType);

            if (projectType == objectType)
            {
                var parentCreator = contract.DefaultCreator;
                contract.DefaultCreator = () =>
                {
                    _project = (Project)parentCreator();
                    return _project;
                };
            }

            if (objectType.IsAssignableTo(iProjectPropertyType))
            {
                var parentCreator = contract.DefaultCreator;
                contract.DefaultCreator = () =>
                {
                    var objectWithProjectProperty = parentCreator();
                    objectType.InvokeMember(
                        "Project",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
                        Type.DefaultBinder,
                        objectWithProjectProperty, new object[] { _project }
                    );
                    return objectWithProjectProperty;
                };
            }

            return contract;
        }
    }
}
