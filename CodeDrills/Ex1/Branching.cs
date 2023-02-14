namespace CodeDrills;

public class Branching
{
    public void IfElse1(int a)
    {
        if (a > 5)
        {
            Console.WriteLine("A");
        }
        else
        {
            Console.WriteLine("B");
        }
    }

    public void IfElse2(int a, int b)
    {
        if (a < 3 && b > 3)
        {
            Console.WriteLine("A");
        }
        else
        {
            Console.WriteLine("B");
        }
    }

    public void IfElse3(int a, int b)
    {
        if (a < 3 || b > 3)
        {
            Console.WriteLine("A");
        }
        else
        {
            Console.WriteLine("B");
        }
    }

    public void IfElse4(int a, int b, int c)
    {
        if (a < 3 || b > 3 && c > 10)
        {
            Console.WriteLine("A");
        }
        else
        {
            Console.WriteLine("B");
        }
    }
    public void IfElse5(int a)
    {
        int b = 7;
        if (a > 5)
        {
            b = 3;
        }
        else if (a > 3)
        {
            b = 9;
        }

        if (b <= 7)
        {
            if (a < 0)
            {
                Console.WriteLine("A");
                return;
            }

            Console.WriteLine("B");
        }
        else
        {
            Console.WriteLine("C");
        }
    }
}