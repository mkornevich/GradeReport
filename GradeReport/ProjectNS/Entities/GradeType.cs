using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class GradeType
    {
        public const string Course = "Course";

        public const string Semester = "Semester";

        public const string Exam = "Exam";

        public static readonly GradeType[] gradeTypes = {
            new GradeType(Course, "Курсовая", false),
            new GradeType(Semester, "Семестровая", true),
            new GradeType(Exam, "Экзаменационная", false),
        };

        public string Name { get; private set; }

        public string Description { get; private set; }

        public bool AllowSpecialGrades { get; private set; }

        private GradeType(string name, string description, bool allowSpecialGrades)
        {
            Name = name;
            Description = description;
            AllowSpecialGrades = allowSpecialGrades;
        }

        public static GradeType GetByName(string name)
        {
            foreach (var type in gradeTypes)
            {
                if (type.Name == name)
                {
                    return type;
                }
            }
            return null;
        }
    }
}
