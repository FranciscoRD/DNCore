namespace Cap06.While
{
    public class WhileCounter
    {
        public static void Principal()
        {
            int counter = 1;
            while (counter <= 10)
            {
                System.Console.Write($"{counter} ");
                ++counter;
            }
            System.Console.WriteLine();
        }
    }
}