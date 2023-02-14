namespace CodeDrills;

/// <summary>
/// Loops
/// </summary>
public class HowManyWriteLine
{
    public void HowManyFor1()
    {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(i);
        }
    }

    public void HowManyFor2()
    {
        for (int i = 0; i <= 172; i++)
        {
            Console.WriteLine(i);
        }
    }

    public void HowManyFor3()
    {
        for (int i = 75; i <= 200; i += 6)
        {
            Console.WriteLine(i);
        }
    }

    public void HowManyFor4()
    {
        string s = "foobar";
        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine(i);
        }
    }

    public void HowManyDoWhile1()
    {
        int i = 10;
        do
        {
            Console.WriteLine(i);
            i += 20;
        } while (i > 50);
    }

    public void HowManyDoWhile2()
    {
        int i = 100;
        do
        {
            Console.WriteLine(i);
            i += 20;
        } while (i <= 200);
    }

    public void HowManyLoopsWhile1()
    {
        int i = 100;
        while (true)
        {
            Console.WriteLine(i);
            i += 20;
            if (i <= 200)
            {
                break;
            }
        }
    }

    public void HowManyLoopsWhile2()
    {
        int i = 0;
        while (i < 100)
        {
            i++;
            if (i < 20)
            {
                continue;
            }

            Console.WriteLine(i);
        }
    }
}