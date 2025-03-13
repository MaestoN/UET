using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n != 0)
            {
                Console.WriteLine("Shkruani nr e ushtrimi qe doni te ekzekutohet 1-14 ose 0 per te mbyllur programin: ");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case (1):
                        Ushtrimi1();
                        break;
                    case (2):
                        Ushtrimi2();
                        break;
                    case (3):
                        Ushtrimi3();
                        break;
                    case (4):
                        Ushtrimi4();
                        break;
                    case (5):
                        Ushtrimi5();
                        break;
                    case (6):
                        Ushtrimi6();
                        break;
                    case (7):
                        Ushtrimi7();
                        break;
                    case (8):
                        Ushtrimi8();
                        break;
                    case (9):
                        Ushtrimi9();
                        break;
                    case (10):
                        Ushtrimi10();
                        break;
                    case (11):
                        Ushtrimi11();
                        break;
                    case (12):
                        Ushtrimi12();
                        break;
                    case (13):
                        Ushtrimi13();
                        break;
                    case (14):
                        Ushtrimi14();
                        break;
                }
            }

            static void Ushtrimi1()
            {
                Console.WriteLine("1) Fusni nje nr: ");
                int n = Convert.ToInt32(Console.ReadLine());


                int j = 1;

                while (j <= n)
                {
                    Console.WriteLine(j);
                    j++;
                }
            }

            static void Ushtrimi2()
            {
                Console.WriteLine("2)Shkruani 3 numra: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());
                int n3 = Convert.ToInt32(Console.ReadLine());

                if (n1 > n2 && n1 > n3)
                {
                    Console.WriteLine($"Nr me i madh eshte {n1}");
                    return;
                }
                else if (n2 > n3)
                {
                    Console.WriteLine($"Nr me i madh eshte {n2}");
                    return;
                }
                Console.WriteLine($"Nr me i madh eshte {n3}");
            }

            static void Ushtrimi3()
            {
                Console.WriteLine("3) Fusni nje Numer: ");
                double n4 = Convert.ToDouble(Console.ReadLine());
                int count = 0;
                while (n4 > 1)
                {
                    n4 /= 10;
                    ++count;

                }
                Console.WriteLine(count);
            }
            static void Ushtrimi4()
            {
                Console.WriteLine("Shkruani vitin: ");
                int viti = Convert.ToInt32(Console.ReadLine());


                if (viti % 4 == 0)
                {
                    if (viti % 100 == 0)
                    {
                        if (viti % 400 == 0)
                            Console.WriteLine(viti + " eshte i brishte");
                        else
                            Console.WriteLine(viti + " nuk eshte i brishte");
                    }
                    else
                    {
                        Console.WriteLine(viti + " eshte i brishte");
                    }
                }
                else
                {
                    Console.WriteLine(viti + " nuk eshte i brishte");
                }
            }
            static void Ushtrimi5()
            {
                Console.WriteLine("Shkruani nje String");
                String s = Console.ReadLine();

                char a = s[0];
                bool y = true;

                for (int i = 1; i < s.Length; i++)
                {
                    char b = s[i];

                    if (b != a)
                    {
                        y = false;
                    }
                }
                Console.WriteLine(y);
            }
            static void Ushtrimi6()
            {
                Console.WriteLine("Shkruani nje nr: ");
                int nr = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= nr; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            static void Ushtrimi7()
            {
                Console.WriteLine("Shkruani nje numer: ");
                int c = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= c; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine($"{i}x{j}={i * j}");
                    }
                }
            }
            static void Ushtrimi8()
            {
                Console.WriteLine("Shkruani nje fjali: ");
                string f = Console.ReadLine();
                char d = ' ';
                int count1 = 0;

                for (int i = 0; i < f.Length; i++)
                {
                    if (f[i] == d)
                    {
                        count1++;
                    }
                }
                Console.WriteLine($"Numri i fjaleve ne kete fjali eshte {++count1}");
            }
            static void Ushtrimi9()
            {
                Console.WriteLine("Shkruani dy numra dhe nje operator: ");
                double c1 = Convert.ToInt32(Console.ReadLine());
                double c2 = Convert.ToInt32(Console.ReadLine());
                char c3 = Convert.ToChar(Console.ReadLine());

                switch (c3)
                {
                    case '*':
                        Console.WriteLine($"{c1}x{c2}={c1 * c2}");
                        break;
                    case '/':
                        Console.WriteLine($"{c1}/{c2}={c1 / c2}");
                        break;
                    case '+':
                        Console.WriteLine($"{c1}+{c2}={c1 + c2}");
                        break;
                    case '-':
                        Console.WriteLine($"{c1}-{c2}={c1 - c2}");
                        break;
                }
            }
            static void Ushtrimi10()
            {
                Console.WriteLine("10) Shkruani nje numer: ");
                int c4 = Convert.ToInt32(Console.ReadLine());
                int R = 0;

                while (c4 > 0)
                {
                    int c5 = c4 % 10;
                    R = R * 10 + c5;
                    c4 /= 10;

                }
                Console.WriteLine($"Numri reverse eshte: {R}");
            }
            static void Ushtrimi11()
            {
                Console.WriteLine("Shkruani nje numer: ");
                int c6 = Convert.ToInt32(Console.ReadLine());
                long F = 1;

                for (int i = c6; i > 0; i--)
                {
                    F *= i;
                }

                Console.WriteLine($"Faktroriali i {c6} eshte {F}");
            }
            static void Ushtrimi12()
            {
                Console.WriteLine("Shkruani nje fjale: ");
                String c7 = Console.ReadLine();

                bool P = true;

                for (int i = 0; i <= c7.Length - 1; i++)
                {
                    int j = c7.Length - 1 - i;

                    if (c7[i] != c7[j])
                        P = false;

                }
                Console.WriteLine($"A eshte {c7} nje palindrome? {P}");

            }

            static void Ushtrimi13()
            {
                Console.WriteLine("Shkruaj nje numer: ");
                int c8 = Convert.ToInt32(Console.ReadLine());

                switch (c8)
                {
                    case (1):
                        Console.WriteLine("E HENE");
                        break;
                    case (2):
                        Console.WriteLine("E MARTE");
                        break;
                    case (3):
                        Console.WriteLine("E MERKURE");
                        break;
                    case (4):
                        Console.WriteLine("E ENJTE");
                        break;
                    case (5):
                        Console.WriteLine("E PREMTE");
                        break;
                    case (6):
                        Console.WriteLine("E SHTUNE");
                        break;
                    case (7):
                        Console.WriteLine("E DIELE");
                        break;
                }



            }
            static void Ushtrimi14()
            {
                Console.WriteLine("14) Shkruani lartesine e piramides: ");
                int c9 = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= c9; i++)
                {

                    for (int s = 0; s < c9 - i; s++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }


                    for (int j = i - 1; j >= 1; j--)
                    {
                        Console.Write(j);
                    }


                    Console.WriteLine();
                }
            }
        }
    }
}


