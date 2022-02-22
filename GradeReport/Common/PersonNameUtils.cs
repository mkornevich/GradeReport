using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Common
{
    public static class PersonNameUtils
    {
        public const string SurnameNP = "S n. p.";

        public static string Format(string fullName, string format)
        {
            var fmt = format;
            var parts = fullName.Split(" ");

            if (parts.Length != 3) return fullName;

            string[] snp = { "s", "n", "p" };

            for (int i = 0; i < snp.Length; i++)
            {
                fmt = fmt.Replace(snp[i], parts[i][0].ToString());
                fmt = fmt.Replace(snp[i].ToUpper(), parts[i]);
            }

            return fmt;
        }
    }
}
