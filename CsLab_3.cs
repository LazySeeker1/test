namespace program
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Input X:");
            string str_x = Console.ReadLine();
            int X = int.Parse(str_x);

            Console.WriteLine("Input Y:");
            string str_y = Console.ReadLine();
            int Y = int.Parse(str_y);

            Console.WriteLine("Entered point is in second square");

            if (X < 0 && Y > 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}