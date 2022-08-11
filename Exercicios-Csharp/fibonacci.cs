using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int a, b, c, i;

            Console.Write("Informe o termo procurado: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num <= 1)
            {
                Console.Write("O TERMO PROCURADO É: {0}", num);
            }
            else
            {
                a = 0; 
                b = 1;
                c = a + b;

                for(i = 2; i < num; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.Write("O VALOR DO TERMO PROCURADO É: {0}", c);
            }
        }
    }
}