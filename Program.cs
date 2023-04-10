/*

64
using System;

class Program {
    static void PrintNumbers(int n) {
        if (n == 1) {
            Console.Write("1");
        } else {
            Console.Write("{0}, ", n);
            PrintNumbers(n - 1);
        }
    }

    static void Main(string[] args) {
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());
        PrintNumbers(n);
    }
}

66
using System;

class Program {
    static int SumRange(int m, int n) {
        if (m > n) {
            return 0;
        } else {
            return m + SumRange(m + 1, n);
        }
    }

    static void Main(string[] args) {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());
        int result = SumRange(m, n);
        Console.WriteLine(result);
    }
}

68
using System;

class Program {
    static int Ackermann(int m, int n) {
        if (m == 0) {
            return n + 1;
        } else if (n == 0) {
            return Ackermann(m - 1, 1);
        } else {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main(string[] args) {
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());
        int result = Ackermann(m, n);
        Console.WriteLine(result);
    }
}
/*