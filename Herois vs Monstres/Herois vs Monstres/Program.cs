using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using Constants;
using Metodos;

namespace PR1
{
    public class Si
    {
        public static void Main()
        {
            int errors = Nums.Zero;
            int initialAnswer = Nums.Zero;
            int stayOrLeave = Nums.Zero;

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = Nums.Zero; i < Text.StartingMessages.Length; i++)
            {
                Console.WriteLine(Text.StartingMessages[i]);
            }
            Console.WriteLine(Text.BlankLine);
            do 
            {
                initialAnswer = Convert.ToInt32(Console.ReadLine());
                stayOrLeave = Class2.StartingMenu(initialAnswer);
                if (stayOrLeave == Nums.Two)
                    errors++;
            } while (errors < Nums.Three && (stayOrLeave != Nums.Zero && stayOrLeave != Nums.One));

            if (errors == Nums.Three)
            {
                Console.WriteLine(Text.MenuErrorLeave);
            }
            else if (stayOrLeave == Nums.One)
            {
                
            }

            
                
        }
    }
}
