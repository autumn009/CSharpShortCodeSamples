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
                    goto end1;
                case 1:
                    Console.Write("ONE:");  // 本当は何かの処理を考える
                    goto end1;
                case 2:
                    Console.Write("TWO:");  // 本当は何かの処理を考える
                    goto end2;
                case 3:
                    Console.Write("THREE:");  // 本当は何かの処理を考える
                    goto end2;
                case 4:
                    Console.Write("FOUR:");  // 本当は何かの処理を考える
                    goto end1;
                    end1:
                    Console.WriteLine("End Process 1");  // 本当は何かの処理を考える
                    break;
                    end2:
                    Console.WriteLine("End Process 2");  // 本当は何かの処理を考える
                    break;
            }
        }
    }
}
