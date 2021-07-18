using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS
{
    public static class EntityUtils
    {
        public static void Copy(Entity from, Entity to)
        {
            var type = from.GetType();

            foreach (var property in type.GetProperties())
            {
                var getMethod = property.GetGetMethod();
                var setMethod = property.GetSetMethod();

                if (getMethod == null || setMethod == null || !Attribute.IsDefined(property, typeof(EntityFieldAttribute))) continue;

                setMethod.Invoke(to, new object[] { getMethod.Invoke(from, null) });
            }
        }

        public static bool Compare(Entity eA, Entity eB)
        {
            if (ReferenceEquals(eA, eB)) 
                return true;

            if (eA == null || eB == null || eA.GetType() != eB.GetType()) 
                return false;

            var type = eA.GetType();

            foreach (var property in type.GetProperties())
            {
                var getMethod = property.GetGetMethod();
                var attribute = (EntityFieldAttribute)Attribute.GetCustomAttribute(property, typeof(EntityFieldAttribute));

                if (getMethod == null || attribute == null || !attribute.Compare) continue;

                var valA = getMethod.Invoke(eA, null);
                var valB = getMethod.Invoke(eB, null);

                if (valA == null && valB == null) continue;

                if (valA == null || valB == null || !valA.Equals(valB))
                    return false;
            }

            return true;
        }
    }
}
