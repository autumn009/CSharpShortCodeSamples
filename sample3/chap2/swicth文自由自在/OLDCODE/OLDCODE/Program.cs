using System;
class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            switch (i)
            {
                case 0:
                    Console.Write("ZERO:");  // 本当は何かの処理を考える
                    break;
                case 1:
                    Console.Write("ONE:");  // 本当は何かの処理を考える
                    break;
                case 2:
                    Console.Write("TWO:");  // 本当は何かの処理を考える
                    break;
                case 3:
                    Console.Write("THREE:");  // 本当は何かの処理を考える
                    break;
                case 4:
                    Console.Write("FOUR:");  // 本当は何かの処理を考える
                    break;
            }
            if (i == 2 || i == 3)
                Console.WriteLine("End Process 2");  // 本当は何かの処理を考える
            else
                Console.WriteLine("End Process 1");  // 本当は何かの処理を考える
        }
    }
}
