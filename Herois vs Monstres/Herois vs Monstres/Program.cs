using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography;
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
            int difficulty = Nums.Zero;
            string names;
            string[] namesArray;
 

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
            } while (errors != Nums.Three && (stayOrLeave != Nums.Zero && stayOrLeave != Nums.One));

            Class2.TotalErrorsAchievedMessage(errors);

            if (stayOrLeave == Nums.One)
            {
                Console.WriteLine(Text.IntroduceNames);
                
                do
                {
                    names = Console.ReadLine();
                    names = names.ToLower();
                    namesArray = names.Split(",");
                    for (int i = Nums.Zero; i < namesArray.Length; i++)
                    {
                        namesArray[i] = namesArray[i].Trim();
                        namesArray[i] = char.ToUpper(namesArray[i][Nums.Zero]) + namesArray[i].Substring(Nums.One);
                    }
                    errors += Class2.CharacterNamesCheck(namesArray);
                    
                } while (errors != Nums.Three && namesArray.Length != Nums.Four);

                Class2.TotalErrorsAchievedMessage(errors);

                if (namesArray.Length == Nums.Four)
                {
                    for (int i = Nums.Zero; i < namesArray.Length; i++)
                    {
                        Console.WriteLine(Text.BlankLine);
                        Console.WriteLine(Text.DificultyMessages[i]);
                    }
                    do
                    {
                        difficulty = Convert.ToInt32(Console.ReadLine());
                        Class2.MaxHp(difficulty);
                        Class2.DamageReduction(difficulty);
                        Class2.AttackDamage(difficulty);
                        
                    } while (errors != Nums.Three && difficulty > Nums.Zero && difficulty < Nums.Zero);
                    
                }

            }            
        }
    }
}
