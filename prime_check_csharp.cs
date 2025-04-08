
using System;

class Program {
    static bool IsPrime(int n) {
        if (n <= 1) return false;
        for (int i = 2; i * i <= n; i++) {
            if (n % i == 0) return false;
        }
        return true;
    }

    static void Main() {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number)) {
            Console.WriteLine(number + " is a prime number.");
        } else {
            Console.WriteLine(number + " is not a prime number.");
        }
    }
}
