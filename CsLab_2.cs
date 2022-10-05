
namespace my_program
{
    class program
    {
        static void Main(string[] args)
        {
            int nk;
            int nn;

            Console.Write("Enter a string of initial elements nn = ");
            string strnn = Console.ReadLine();
            nn = Int32.Parse(strnn);

            Console.Write("Enter a row limit: nk = ");
            string strnk = Console.ReadLine();
            nk = Int32.Parse(strnk);

            if (nn > nk || nn < 0)
            {
                Console.WriteLine("Incorrect values have been entered!");
                Console.Write("Enter the beginning of the series = ");
                strnn = Console.ReadLine();
                nn = Int32.Parse(strnn);
            }

            double Sum = 0;

            for (double i = nn; i < nk; i++)
            {
                Sum += ((i * i) + Math.Pow(-1, i) * i - 1) / (i * i + 1);
            }

            Console.WriteLine("The sum of a number series = " + Sum);

            Console.Read();
        }
    }
}