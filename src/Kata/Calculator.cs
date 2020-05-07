using System;

namespace Kata.Spec
{
    public class Calculator
    {
        public int Add(string number="")
        {
            if (number.Equals(""))
            {
                return 0;                
            }

            var parts = number.Split( new[] {",","\n"}, StringSplitOptions.None);
            if (parts.Length == 1)
            {
                return int.Parse(parts[0]);
            }
            else if (parts.Length >= 2)
            {
                var accum = 0;
                for (int i = 0; i < parts.Length; i++)
                {
                    accum += int.Parse((parts[i]));
                }
                return accum;
            }

            return int.Parse(parts[0]) + int.Parse(parts[1]);
        }
    }
}