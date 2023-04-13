namespace task1
{
    internal class ProgramBase
    {
        static int Largest(Product[] p, int start, int end)
        {
            int index = start;
            float large = p[start].price;
            for (int x = start; x < end; x++)
            {
                if (large < p[x].price)
                {
                    large = p[x].price;
                    index = x;
                }
            }
            return index;
        }
    }
}