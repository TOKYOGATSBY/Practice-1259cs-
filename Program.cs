using System;

class Program
{
    static long EulerPhi(long n)
    {
        long result = n;
        for (long p = 2; p * p <= n; p++)
        {
            if (n % p == 0)
            {
                while (n % p == 0)
                {
                    n /= p;
                }
                result -= result / p;
            }
        }

        if (n > 1)
        {
            result -= result / n;
        }

        return result;
    }

    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        long phiN = EulerPhi(N);
        Console.WriteLine(phiN / 2);
    }
}
