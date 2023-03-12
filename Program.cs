namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[] { 1, 3, 5 };

            for (int i = 0; i <= ages.Length; i++)
            {
                try
                {
                    Console.WriteLine(ages[i]);
                }
                catch
                {
                    Console.WriteLine("We had an error, try again");
                }
            }

            Console.ReadLine();
        }
    }
}
