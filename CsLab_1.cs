
namespace my_program
{
    class program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Enter radius of circle");

            int R = int.Parse(Console.ReadLine());

            double S = (4 * Math.PI * Math.Pow(R, 2));
            double V = ((4 / 3) * Math.PI * Math.Pow(R, 3));

            System.Console.WriteLine(S);
            System.Console.WriteLine(V);

            Console.Read();
        }
    }
}

