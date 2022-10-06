using System;

namespace zadanie
{


    class Program
    {
        static int i = 0;
        static char[] massiv = new char[30];
        static void Main(string[] args)
        {
            for (int j = 0; j < massiv.Length; j++)
            {
                char s = Console.ReadKey().KeyChar;
                AddChar(s);
            }
        }

        static void AddChar(char s)
        {
            int stop = 0;
            for (int j = 0; j < massiv.Length; j++)
            {
                if (massiv[j] == s && stop == 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("данная буква уже присутствует в массиве");
                    stop++;
                } 
            }
            if (stop == 0){
                Console.WriteLine(" ");
                Console.WriteLine("данной буквы еще нет в массивеы");
            }
            massiv[i] = s;
            Console.WriteLine("буква была добавлена в массив");
            i++;
        }

        static bool CheckChar(char s) {
            bool z = true;
            int stop = 0;
            for (int j = 0; j < massiv.Length; j++)
            {
                if (massiv[j] == s && stop == 0)
                {
                    z = true;
                    stop++;
                }
            }
            if (stop == 0)
            {
                z = false;
            }
            return z;
        }
    }
}
