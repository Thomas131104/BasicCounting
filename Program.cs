using System;
using CountExample;

public class Program
{
    public static void Main()
    {
        Count count = new Count(3);
        while (true)
        {
            Console.WriteLine("Nhấn 'a' để tăng hoặc 'l' để giảm: ");
            ConsoleKeyInfo character = Console.ReadKey(true);

            if (character.KeyChar == 'a')
            {
                count.Increasing();
            }

            if (character.KeyChar == 'l')
            {
                count.Decreasing();
            }

            if (!(count.CanChange()))
            {
                break;
            }
        }

        Console.WriteLine("Cảm ơn bạn đã chơi xong chương trình này.");       
    }
}