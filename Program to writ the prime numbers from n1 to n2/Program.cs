using System;
class PrimeNumber
{
    static public void Main()
    {

        int a, b, i, j, flag;

        Console.Write(
        "Enter lower bound of the interval: ");
        a = Convert.ToInt32(
        Console.ReadLine()); 

        Console.Write(
        "\nEnter upper bound of the interval: ");
        b = Convert.ToInt32(
        Console.ReadLine());

        Console.Write("\nPrime numbers between " + a
                    + " and " + b + " are: ");

        if (a == 1)
        {
            Console.Write(a + " ");
            a++;
            if (b >= 2)
            {
                Console.Write(a + " ");
                a++;
            }
        }
        if (a == 2)
        {
            Console.Write(a + " ");
        }

        if (a % 2 == 0)
        {
            a++;
        }

        for (i = a; i <= b; i = i + 2)
        {

            flag = 1;

            for (j = 2; j * j <= i; ++j)
            {
                if (i % j == 0)
                {
                    flag = 0;
                    break;
                }
            }

            if (flag == 1)
            {
                Console.Write(i + " ");
            }
        }
    }
}

