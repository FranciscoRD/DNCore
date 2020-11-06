namespace Cap06.For
{
    public class Sum
    {
        public static void Principal()
        {
            int total = 0;
            for (int number = 2; number <= 20; number += 2)
            {
                total += number;
            }
            System.Console.WriteLine($"Sum is {total}");
        }
    }
}