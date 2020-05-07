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

            var parts = number.Split(",");
            if (parts.Length == 1)
            {
                return int.Parse(parts[0]);
            }

            return int.Parse(parts[0]) + int.Parse(parts[1]);
        }
    }
}