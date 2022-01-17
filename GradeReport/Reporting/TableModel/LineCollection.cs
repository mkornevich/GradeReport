using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.TableModel
{
    public abstract class LineCollection<TLine> : List<TLine> where TLine : Line
    {
        public TLine FindByName(string name) => Find(l => l.Name == name);

        public List<TLine> FindAllByGroup(string group) => FindAll(l => l.Group == group);
    }
}
