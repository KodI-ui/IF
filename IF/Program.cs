using System;

namespace IF
{
    class Program
    {
        static void Main(string[] args)
        {
            /*If1();*/
            If20();
            /*If29();
            If28();
            If27();*/
        }
        static void IfExample()
        {
            int i = 25;
            /*если(условие){
                решение;
            } */
            if(i > 0)
            {

            }
            else if(i < 0)
            {

            }
            else
            {

            }
        }
        static void If1()
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 0) num++;
            Console.WriteLine(num);
           
        }
        static void If2()
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 0) num++;
            else num -= 2;
            Console.WriteLine(num);
        }
        static void If30()
        {
            int num = int.Parse(Console.ReadLine());
            String negation = num % 2 == 0 ? "" : "ne";
            String numberOfDigits = "";
            if (num / 100 != 0) numberOfDigits = "3-x";
            else if (num / 10 > 0 && num / 10 < 10) numberOfDigits = "2-x";
            else numberOfDigits = "1-o";
            Console.WriteLine($"{numberOfDigits} znachnoe {negation}chetnoe chislo");
        }
        static void If29()
        {
            int num = int.Parse(Console.ReadLine());
            String negation = num % 2 == 0 ? "" : "ne";
            String plusOrMinus = "";
            if (num < 0) plusOrMinus = "Otritsatelbnoe";
            else if (num > 0) plusOrMinus = "Polozhitelbnoe";
            else plusOrMinus = "Nulevoe";
            Console.WriteLine($"{plusOrMinus} {negation}chetnoe chislo");
        }
        static void If28()
        {
            int year = int.Parse(Console.ReadLine());
            if (year % 100 == 0) year /= 100;
            String leapYear = year % 4 == 0 ? "Visokosnii" : "Defoultnii";
            Console.WriteLine(leapYear);
        }
        static void If27()
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 0) num = 0;
            else if (num % 2 == 0) num = 1;
            else num = -1;
            Console.WriteLine(num);
        }
        static void If26()
        {
            int num = int.Parse(Console.ReadLine());
            if (num <= 0) num = -num;
            else if (0 < num && num < 2) num *= num;
            else num = 4;
            Console.WriteLine(num);
        }
        static void If25()
        {
            int x = int.Parse(Console.ReadLine());
            if (x < -2 || x > 2) x *= 2;
            else x *= -3;
            Console.WriteLine(x);
        }
        static void If24()
        {
            double x = double.Parse(Console.ReadLine());
            double y = x <= 0 ? 6 - x : 2 * Math.Sin(x);
            Console.WriteLine(y);
        }
        static void If23()
        {
            int x1, y1, x2, y2, x3, y3;
            Console.Write($"x1 = ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write($"y1 = ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write($"x2 = ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write($"y2 = ");
            y2 = int.Parse(Console.ReadLine());
            Console.Write($"x3 = ");
            x3 = int.Parse(Console.ReadLine());
            Console.Write($"y3 = ");
            y3 = int.Parse(Console.ReadLine());
            if (x2 == x3) Console.WriteLine($"x4 = {x1}");
            else if (x3 == x1) Console.WriteLine($"x4 = {x2}");
            else Console.WriteLine($"x4 = {x3}");
            if (y2 == y3) Console.WriteLine($"x4 = {y1}");
            else if (y3 == y1) Console.WriteLine($"x4 = {y2}");
            else Console.WriteLine($"x4 = {y3}");
        }
        static void If22()
        {
            Console.Write("OX = ");
            int OX = int.Parse(Console.ReadLine());
            Console.Write("OY = ");
            int OY = int.Parse(Console.ReadLine());
            String Chastb = "";
            if (OX > 0 && OY > 0) Chastb = "1-aya";
            else if (OX > 0 && OY < 0) Chastb = "4-aya";
            else if (OX < 0 && OY > 0) Chastb = "2-aya";
            else Chastb = "3-aya";
            Console.WriteLine($"{Chastb} chetvertb");
        }
        static void If21()
        {
            Console.Write("OX = ");
            int OX = int.Parse(Console.ReadLine());
            Console.Write("OY = ");
            int OY = int.Parse(Console.ReadLine());
            int num = 0;
            if (OX == 0 && OY == 0) num = 0;
            else if (OX == 0) num = 1;
            else if (OY == 0) num = 2;
            else num = 3;
            Console.WriteLine(num);
            
        }
        static void If20()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            String abc = Math.Sqrt(A - B) < Math.Sqrt(A - C) ? "B blizhe k A" : "C blizhe k A";
            Console.WriteLine(abc);
        }
        static void If19()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            if (A != B && A != C) Console.WriteLine("1");
            else if (B != A && B != C) Console.WriteLine("2");
            else if (C != A && C != B) Console.WriteLine("3");
            else Console.WriteLine("4");
        }
        static void If18()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            if (A != B && A != C) Console.WriteLine("1");
            else if (B != A && B != C) Console.WriteLine("2");
            else if (C != A && C != B) Console.WriteLine("3");
        }
        static void If17()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            bool ABC = A > B && B > C;
            bool CBA = C > B && B > A;
            if(ABC == true || CBA == true)
            {
                A *= A;
                B *= B;
                C *= C;
            }
            else
            {
                A = -A;
                B = -B;
                C = -C;
            }
            Console.WriteLine($"{A} {B} {C}");
        }
        static void If16()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            bool ABC = A > B && B > C;
            if (ABC == true)
            {
                A *= A;
                B *= B;
                C *= C;
            }
            else
            {
                A = -A;
                B = -B;
                C = -C;
            }
            Console.WriteLine($"{A} {B} {C}");
        }
        static void If15()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            if(A > B && C > B)
            {
                Console.WriteLine(A + B);
            }
            else if(B > A && C > A)
            {
                Console.WriteLine(B + C);
            }
            else
            {
                Console.WriteLine(A + C);
            }
        }
        static void If14()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            if(A > B && B > C)
            {
                Console.WriteLine($"{A} {C}");
            }
            else if(B > A && A > C)
            {
                Console.WriteLine($"{B} {C}");
            }
            else
            {
                Console.WriteLine($"{A} {B}");
            }
        }
        static void If13()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            if (A > B && B > C)
            {
                Console.WriteLine($"{B}");
            }
            else if (B > A && A > C)
            {
                Console.WriteLine($"{A}");
            }
            else
            {
                Console.WriteLine($"{C}");
            }
        }
        static void If12()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            if (A > B && C > B)
            {
                Console.WriteLine($"{B}");
            }
            else if (B > A && C > A)
            {
                Console.WriteLine($"{A}");
            }
            else
            {
                Console.WriteLine($"{C}");
            }
        }
        static void If11()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            if (A > B || B > A)
            {
                if (A > B) B = A;
                else A = B;
            }
            else
            {
                A = 0;
                B = 0;
            }
            Console.WriteLine($"{A} {B}");
        }
        static void If10()
        {
            int A = int.Parse(Console.ReadLine());
            int C = A;
            int B = int.Parse(Console.ReadLine());
            if (A > B || B > A)
            {
                A += B;
                B += C;
            }
            else
            {
                A = 0;
                B = 0;
            }
            Console.WriteLine($"{A} {B}");
        }
        static void If9()
        {
            int A = int.Parse(Console.ReadLine());
            int C = A;
            int B = int.Parse(Console.ReadLine());
            if (A > B)
            {
                A = B;
                B = C;

            }
            Console.WriteLine($"{A} {B}");

        }
        static void If8()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            if (A > B) Console.WriteLine($"{A} {B}");
            else Console.WriteLine($"{B} {A}");
        }
        static void If7()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            if (A > B) Console.WriteLine("1");
            else Console.WriteLine("2");
        }
        static void If6()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            if (A > B) Console.WriteLine(A);
            else Console.WriteLine(B);
        }
        static void If5()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            if (A < 0 && B < 0 && C < 0) Console.WriteLine("3 отрицательных числа");
            else if ((A < 0 && B < 0 && C > 0) || (A < 0 && B > 0 && C < 0) || (A > 0 && B < 0 && C < 0))
            {
                Console.WriteLine("2 отрицательных и одно положительное число");
            }
            else if (A > 0 && B > 0 && C > 0) Console.WriteLine("все числа положительные");
            else Console.WriteLine("2 положительных и одно отрицательное число");
        }
    }
}
