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
            double[] HP = new double[5];
            int[] DMG = new int[5]; 
            int [] DMGReduction = new int[5];
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
                        switch (difficulty)
                        {
                            case 1:
                                HP = Const.EasyHp;
                                DMG = Const.EasyDMG;
                                DMGReduction = Const.EasyDMGReduction;
                                break;
                            case 2:
                                HP = Const.HardHp;
                                DMG = Const.HardDMG;
                                DMGReduction = Const.HardDMGReduction;
                                break;
                            case 3:
                                for (int i = Const.Zero; i < Const.Five; i++)
                                {
                                    Random random = new Random();
                                    HP[i] = random.NextDouble() * (Const.HardHp[i] - Const.EasyHp[i]) + Const.EasyHp[i];
                                    DMG[i] = random.Next(Const.EasyDMG[i], Const.HardDMG[i]);
                                    DMGReduction[i] = random.Next(Const.EasyDMGReduction[i], Const.HardDMGReduction[i]);
                                }
                                break;
                            case 4:
                                for (int i = 0; i < Const.Three; i++)
                                {
                                    for (int j = 0; j < 5; j++)
                                    {
                                        Console.WriteLine($"Introdueix {Const.Stats[j]} de {namesArray[j]} ({Const.EasyHp[j]} - {Const.HardHp[j]})");
                                        
                                    }
                                }
                                
                                break;
                            default: 
                                errors++;
                                break;
                        }

                    } while (errors != Const.Three && (difficulty < Const.Zero || difficulty > Const.Four));

                }
            }
                        
        }
    }
}
