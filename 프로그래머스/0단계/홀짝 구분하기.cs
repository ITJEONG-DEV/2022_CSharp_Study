using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        
        if(a%2==0)
        {
            Console.Write("{0} is even", a);
        }
        else
        {
            Console.Write("{0} is odd", a);
        }
    }
}