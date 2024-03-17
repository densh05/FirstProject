using System;

namespace Loop
{
    // F10 
    // F11

    class Program
    {
        static void Main()
        {
           for (int i = 0; i < 10; i++)
            {
                WriteRhombus();
            }
        }
        static void WriteRhombus()
        {
            for (int i = 1; i < 11; i = i + 2)
            {
                // Відступ зліва
                for (int j = 0; j < (11 - i) / 2; j++)
                {
                    Console.Write(" ");
                }


                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }


                // Відступ справа
                for (int j = 0; j < (11 - i) / 2; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            for (int i = 11; i >= 1; i = i - 2)
            {
                // Відступ зліва
                for (int j = 0; j < (11 - i) / 2; j++)
                {
                    Console.Write(" ");
                }


                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }


                // Відступ справа
                for (int j = 0; j < (11 - i) / 2; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }  
}