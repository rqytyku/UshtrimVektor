using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Write a program to find a sequence of neighbor numbers in an array, which has a sum of certain number S.
// Example:{4,3,1,4,2,5,8}, S = 11 → {4,2,5}.
// The array of numbers and the number S will be provided by the user.


namespace UshtrimVektor
{
    class Program
    {
        static void Main(string[] args)
        {
            int Shuma = 0, a = 0, b = 0;
            bool Sh = false;

            Console.Write("Jep Shumen: ");
            int shuma = Convert.ToInt32(Console.ReadLine());

            Console.Write("Madhesia e vektorit: ");
            int gjatesia = Convert.ToInt32(Console.ReadLine());

            int[] Vektori = new int[gjatesia];

            for (int i = 0; i < gjatesia; i++)
            {
                Console.Write("Jep elementin {0} : ", i+1);
                Vektori[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < gjatesia - 1; i++)
            {
                Shuma = Vektori[i];

                for (int j = i + 1; j < gjatesia; j++)
                {
                    Shuma += Vektori[j];
                    if (Shuma == shuma)
                    {
                        a = i;
                        b= j;
                        Sh = true;
                        break;
                    }
                }

                if (Sh) break;
            }

            if (Sh)
                for (int i = a; i <= b; i++) Console.Write("{0},", Vektori[i]);
            else Console.WriteLine("Nuk u gjend shuma qe ju kerkoni.");
            Console.ReadKey();
        }
        
    }
}
