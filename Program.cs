using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = DateTime.Now.ToString();
            string s2 = DateTime.Now.ToString("F");
          
            Console.WriteLine(s2);
            Console.WriteLine(s1);
            Console.WriteLine(" In first date: ");
            m(s2);
            Console.WriteLine(" In second date: ");
            m(s1);
           
        }
        static void m(string s1)
        {
            int n0 = 0, n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0, n6 = 0, n7 = 0, n8 = 0, n9 = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                switch (s1[i])
                {
                    case '0':
                        n0++;
                        break;
                    case '1':
                        n1++;
                        break;
                    case '2':
                        n2++;
                        break;
                    case '3':
                        n3++;
                        break;
                    case '4':
                        n4++;
                        break;
                    case '5':
                        n5++;
                        break;
                    case '6':
                        n6++;
                        break;
                    case '7':
                        n7++;
                        break;
                    case '8':
                        n8++;
                        break;
                    case '9':
                        n9++;
                        break;
                    default: break;
                }
            }
            Console.WriteLine($" Zeros: {n0}\n Ones: {n1}\n Twos: {n2}\n Triples: {n3}\n Foures: {n4}\n Fives: {n5}\n" +
           $" Sixes: {n6}\n Sevens: {n7}\n Eights: {n8}\n Nines: {n9}");
        }
    }
}
