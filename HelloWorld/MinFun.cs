namespace HelloWorld
{
    public class MinFun
    {

        static void Main()
        {
            
        }
        
        private static string GetMinX(int a, int b, int c)
        {
            double res;
            if (a > 0)
            {
                res = -((double) b / (2 * a));
                return res.ToString();
            }

            if (a == 0 && b == 0)
            {
                return "";
            }

            string e = "Impossible";
            return e;
        }
    }
}