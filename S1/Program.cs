using System;

namespace S1;
class S1
{
    static void Main(string[] args)
    {
        int n = 1;
        while (n != 0)
        {
            Console.WriteLine("Shkruani nr e ushtrimit qe doni te ekzekutohet 1-10 ose 0 per te mbyllur programin: ");
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
            }
        }

        static void Ushtrimi1()
        {
            Console.WriteLine("Shkruani Emrin, Mbiemrin, Moshen, Gjinine");
            string e = Console.ReadLine();
            string m = Console.ReadLine();
            int mosha = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();

            Console.WriteLine($"Emri: {e}\nMbiermri: {m}\nMosha: {mosha}\nGjinia: {s}");
        }

        static void Ushtrimi2()
        {
            Console.WriteLine("Shkruani dy numra te plote ku numri i pare te jete me i madh se i dyti: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine($"Mbetja nga pjestimi i {n1} me {n2} eshte {n1 % n2}");
            }
            else
                Console.WriteLine("Numri i pare duhet te jete me i madh");
        }


        static void Ushtrimi3()
        {
            Console.WriteLine("Shkruani pese numra te plote: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            int n4 = Convert.ToInt32(Console.ReadLine());
            int n5 = Convert.ToInt32(Console.ReadLine());

            int sum = n1 + n2 + n3 + n4 + n5;
            double avg = sum / 5;
            Console.WriteLine($"Shuma eshte {sum} dhe mesatarja eshte {avg} ");
        }

        static void Ushtrimi4()
        {
            int e1 = (-10) + 7 * 5;
            int e2 = (25 + 4) % 9;
            int e3 = 10 + (-3) * 4 / 9;
            int e4 = 1 + 23 / 3 * 2 - 7 / 3;

            Console.WriteLine($"(-10) + 7 * 5={e1} \n(25 + 4) % 9={e2} \n10 + (-3) * 4 / 9={e3} \n1 + 23 / 3 * 2 - 7 / 3={e4}");
        }

        static void Ushtrimi5()
        {
            Console.WriteLine("Shkruani dy numra te plote: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            bool x = n1 == n2;
            Console.WriteLine($"A jane nr e barabarte? {x}");
        }

        static void Ushtrimi6()
        {

            int x = 1;
            while (x!=0)
            {
                Console.WriteLine("Shkruani 1 per Drejkendesh 2 per Trekendesh 3 per Rreth 4 per Trapez 0 per te dale: ");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Fusni brinjet e Drejtkendeshit");
                        int b1 = Convert.ToInt32(Console.ReadLine());
                        int b2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Perimetri eshte {2 * b1 + 2 * b2}. Siperfaqa eshte {b1 * b2}");
                        break;
                    case 2:
                        Console.WriteLine("Fusni brinjet dhe lartesine e Trekendeshit");
                        int b01 = Convert.ToInt32(Console.ReadLine());
                        int b02 = Convert.ToInt32(Console.ReadLine());
                        int b03 = Convert.ToInt32(Console.ReadLine());
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($" Perimetri eshte {b01 + b02 + b03}. Siperfaqa eshte {b01 * h}");
                        break;

                    case 3:
                        Console.WriteLine("Fusni rrezen e rrethit");
                        double r = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($" Perimetri eshte {2 * Math.PI * r}. Siperfaqa eshte {Math.PI * r * r}");
                        break;
                    case 4:
                        Console.WriteLine("Fusni brinjet dhe lartesine e trapezit");
                        int b4 = Convert.ToInt32(Console.ReadLine());
                        int b5 = Convert.ToInt32(Console.ReadLine());
                        int h1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($" Perimetri eshte {2 * b4 + 2 * b5}. Siperfaqa eshte {((b4 + b5) * h1) / 2}");
                        break;
                }
            }
            
        }

        static void Ushtrimi7()
        {
            Console.WriteLine("Shkruani dy numra: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine($"Variabli 1: {n1}. Variabli 2: {n2}.");
        }

        static void Ushtrimi8()
        {
            Console.WriteLine("Shkruani titullin, emrin e autorit, cmimin e librit 1: ");
            string a1 = Console.ReadLine();
            string t1 = Console.ReadLine();
            string c1 = Console.ReadLine();
            Console.WriteLine("Shkruani titullin, emrin e autorit, cmimin e librit 2: ");
            string a2 = Console.ReadLine();
            string t2 = Console.ReadLine();
            string c2 = Console.ReadLine();
            Console.WriteLine($"Libri 1:\nTitulli {t1}\nAutori {a1}\nCmimi {c1}\n");
            Console.WriteLine($"Libri 2:\nTitulli {t2}\nAutori {a2}\nCmimi {c2}");
        }

        static void Ushtrimi9()
        {
            int n=1;

            while (n != 0)
            {
                Console.WriteLine("Zgjidhni monedhen qe doni te konvertoni 1 USD 2 Euro 0 per te dale");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Shkrunai shumen qe doni te konvertoni: ");
                double n1 = Convert.ToDouble(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine($"{n1} ALL = {n1 / 92.4} USD");
                        break;
                    case 2:
                        Console.WriteLine($"{n1} ALL = {n1 / 99.5} Euro");
                    break;
                }
            }   
        }
        static void Ushtrimi10()
        {
            Console.WriteLine("Shkruani nje numer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{n}x{i}={n * i}");
            }
        }
    }

}

