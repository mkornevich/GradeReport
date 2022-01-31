using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ProjectModel.Entities
{
    public class GradeValue
    {
        // оценка
        public const int Grade = 0;

        // пусто
        public const int Empty = -1;

        // зачтено
        public const int Passed = -2;

        // освобожден
        public const int Released = -3;

        public static readonly GradeValue[] GradeValues = {
            new GradeValue("0", 0, "ноль", new Keys[] {Keys.NumPad0, Keys.D0}),
            new GradeValue("1", 1, "один", new Keys[] {Keys.NumPad1, Keys.D1}),
            new GradeValue("2", 2, "два", new Keys[] {Keys.NumPad2, Keys.D2}),
            new GradeValue("3", 3, "три", new Keys[] {Keys.NumPad3, Keys.D3}),
            new GradeValue("4", 4, "четыре", new Keys[] {Keys.NumPad4, Keys.D4}),
            new GradeValue("5", 5, "пять", new Keys[] {Keys.NumPad5, Keys.D5}),
            new GradeValue("6", 6, "шесть", new Keys[] {Keys.NumPad6, Keys.D6}),
            new GradeValue("7", 7, "семь", new Keys[] {Keys.NumPad7, Keys.D7}),
            new GradeValue("8", 8, "восемь", new Keys[] {Keys.NumPad8, Keys.D8}),
            new GradeValue("9", 9, "девять", new Keys[] {Keys.NumPad9, Keys.D9}),
            new GradeValue("10", 10, "десять", new Keys[] {Keys.Multiply, Keys.L}),

            new GradeValue("", Empty, "", new Keys[] {Keys.Back, Keys.Delete}),
            new GradeValue("Зач", Passed, "Зачтено", new Keys[] {Keys.P}),
            new GradeValue("Осв", Released, "Осв", new Keys[] {Keys.J}),
        };

        public readonly string StringValue;

        public readonly int Value;

        public readonly Keys[] KeyCodes;

        public readonly string Description;

        private GradeValue(string stringValue, int value, string description, Keys[] keyCodes)
        {
            StringValue = stringValue;
            Value = value;
            Description = description;
            KeyCodes = keyCodes;
        }

        public static GradeValue GetByValue(int value) => GradeValues.ToList().Find(gv => gv.Value == value);

        public static GradeValue GetByKeyCode(Keys keyCode) => GradeValues.ToList().Find(gv => gv.KeyCodes.Contains(keyCode));

        public static string ToString(object grade, string format = "v", string emptyFormat = "", string errorFormat = "ev")
        {
            var error = "";
            var value = "";
            var description = "";

            var currFormat = errorFormat;

            if (grade != null)
            {
                int gradeValue;
                var gradeValueStr = grade.ToString();
                value = gradeValueStr;
                if (int.TryParse(gradeValueStr, out gradeValue))
                {
                    var gradeValueObj = GradeValues.ToList().Find(gv => gv.Value == gradeValue);
                    if (gradeValueObj != null)
                    {
                        value = gradeValueObj.StringValue;
                        description = gradeValueObj.Description;
                        currFormat = gradeValue == Empty ? emptyFormat : format;
                    }
                    else
                    {
                        error = "nf";
                    }
                }
                else
                {
                    error = "ni";
                }
            }
            else
            {
                error = "nu";
            }

            return currFormat.Replace("v", value).Replace("d", description).Replace("e", error);
        }
    }
}
