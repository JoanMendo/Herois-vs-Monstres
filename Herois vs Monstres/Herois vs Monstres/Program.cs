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
            int errors = Const.Zero;
            int initialAnswer = Const.Zero;
            int stayOrLeave = Const.Zero;
            int difficulty = Const.Zero;
            double[] HP;
            int[] DMG; 
            int [] DMGReduction;
            string names;
            string[] namesArray;



            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = Const.Zero; i < Const.StartingMessages.Length; i++)
            {
                Console.WriteLine(Const.StartingMessages[i]);
            }
            Console.WriteLine(Const.BlankLine);
            do 
            {
                initialAnswer = Convert.ToInt32(Console.ReadLine());
                stayOrLeave = Class2.StartingMenu(initialAnswer);
                if (stayOrLeave == Const.Two)
                    errors++;
            } while (errors != Const.Three && (stayOrLeave != Const.Zero && stayOrLeave != Const.One));

            Class2.TotalErrorsAchievedMessage(errors);

            if (stayOrLeave == Const.One)
            {
                Console.WriteLine(Const.IntroduceNames);

                do
                {

                    Console.WriteLine(Const.BlankLine);
                    names = Console.ReadLine();
                    names = names.ToLower();
                    namesArray = names.Split(",");
                    for (int i = Const.Zero; i < namesArray.Length; i++)
                    {
                        namesArray[i] = namesArray[i].Trim();
                        namesArray[i] = char.ToUpper(namesArray[i][Const.Zero]) + namesArray[i].Substring(Const.One);
                    }
                    errors += Class2.CharacterNamesCheck(namesArray);

                } while (errors != Const.Three && namesArray.Length != Const.Four);

                Class2.TotalErrorsAchievedMessage(errors);

                if (namesArray.Length == Const.Four)
                {
                    for (int i = Const.Zero; i < namesArray.Length; i++)
                    {
                        Console.WriteLine(Const.BlankLine);
                        Console.WriteLine(Const.DificultyMessages[i]);
                    }
                    do
                    {
                        difficulty = Convert.ToInt32(Console.ReadLine());
                        HP = Class2.MaxHp(difficulty);
                        DMG = Class2.DamageReduction(difficulty);
                        DMGReduction = Class2.AttackDamage(difficulty);
                        errors += Class2.CharactersStatsCheck(difficulty);
                    } while (errors != Const.Three &&( difficulty < Const.Zero || difficulty > Const.Four));

                }
            }
                        
        }
    }
}
