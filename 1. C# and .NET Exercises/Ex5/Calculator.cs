namespace MathLib
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int[] ints)
        {
            var res = 0;
            foreach (var n in ints)
            {
                res += n;
            }
            return res;
        }
    }
}