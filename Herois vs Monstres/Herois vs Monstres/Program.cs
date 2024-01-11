using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using Constants;
using Metodos;

namespace PR1
{
    public class si
    {
        public static void Main()
        {

            int errors = Nums.Zero;
            int initialAnswer = Constantes.Zero;
            int stayOrLeave = Constantes.Zero;
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = Constantes.Zero; i < Constantes.StartingMessages.Length; i++)
            {
                Console.WriteLine(Constantes.StartingMessages[i]);
            }
            Console.WriteLine(Constantes.BlankLine);
            do 
            {
                initialAnswer = Convert.ToInt32(Console.ReadLine());
                stayOrLeave = Class2.StartingMenu(initialAnswer);
                if (stayOrLeave == 2)
                    errors++;
            } while (errors < Constantes.Three && (stayOrLeave != 0 && stayOrLeave != 1));

            if (errors == Constantes.Three)
            {
                Console.WriteLine(Constantes.MenuErrorLeave);
            }
            else if (stayOrLeave == Constantes.One)
            {
                
            }

            
                
        }
    }
}
