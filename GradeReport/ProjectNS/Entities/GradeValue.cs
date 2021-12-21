using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ProjectNS.Entities
{
    public class GradeValue
    {
        // пусто
        public const int Empty = -1;

        // зачтено
        public const int Passed = -2;

        // освобожден
        public const int Released = -3;

        public static readonly GradeValue[] GradeValues = {
            new GradeValue("0", 0, new Keys[] {Keys.NumPad0, Keys.D0}),
            new GradeValue("1", 1, new Keys[] {Keys.NumPad1, Keys.D1}),
            new GradeValue("2", 2, new Keys[] {Keys.NumPad2, Keys.D2}),
            new GradeValue("3", 3, new Keys[] {Keys.NumPad3, Keys.D3}),
            new GradeValue("4", 4, new Keys[] {Keys.NumPad4, Keys.D4}),
            new GradeValue("5", 5, new Keys[] {Keys.NumPad5, Keys.D5}),
            new GradeValue("6", 6, new Keys[] {Keys.NumPad6, Keys.D6}),
            new GradeValue("7", 7, new Keys[] {Keys.NumPad7, Keys.D7}),
            new GradeValue("8", 8, new Keys[] {Keys.NumPad8, Keys.D8}),
            new GradeValue("9", 9, new Keys[] {Keys.NumPad9, Keys.D9}),
            new GradeValue("10", 10, new Keys[] {Keys.Multiply, Keys.L}),

            new GradeValue("", Empty, new Keys[] {Keys.Back, Keys.Delete}),
            new GradeValue("Зач", Passed, new Keys[] {Keys.P}),
            new GradeValue("Осв", Released, new Keys[] {Keys.J}),
        };

        public readonly string DisplayAs;

        public readonly int Value;

        public readonly Keys[] KeyCodes;

        private GradeValue(string displayAs, int value, Keys[] keyCodes)
        {
            DisplayAs = displayAs;
            Value = value;
            KeyCodes = keyCodes;
        }

        public static GradeValue GetByValue(int value) => GradeValues.ToList().Find(gv => gv.Value == value);

        public static GradeValue GetByKeyCode(Keys keyCode) => GradeValues.ToList().Find(gv => gv.KeyCodes.Contains(keyCode));
    }
}
