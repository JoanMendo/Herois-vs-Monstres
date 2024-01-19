﻿using Constants;
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
            double[,] stats = new double[3, 5];
            string names;
            string[] namesArray;
            Random random = new Random();



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

            Class2.ErrorTester(errors);

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
                    errors += Class2.ErrorTester(namesArray);

                } while (errors != Const.Three && namesArray.Length != Const.Five);

                Class2.ErrorTester(errors);

                if (namesArray.Length == Const.Five)
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
                                stats = Const.EasyStats;
                                break;
                            case 2:
                                stats = Const.HardStats;
                                break;
                            case 3:

                                for (int i = Const.Zero; i < Const.Five; i++)
                                {
                                    for (int j = Const.One; j < Const.Three; j++)
                                    {
                                        if (Const.EasyStats[j, i] > Const.HardStats[j, i])
                                            stats[j, i] = random.NextDouble() * (Const.EasyStats[j, i] - Const.HardStats[j, i]) + Const.HardStats[j, i];
                                        else
                                            stats[j, i] = random.NextDouble() * (Const.HardStats[j, i] - Const.EasyStats[j, i]) + Const.EasyStats[j, i];
                                    }
                                }
                                break;
                            case 4:
                                for (int i = 0; i < Const.Three; i++)
                                {
                                    for (int j = 0; j < 5; j++)
                                    {
                                        errors = 0;
                                        while (errors != 3)
                                        {
                                            if (Const.EasyStats[i, j] > Const.HardStats[i, j])
                                                Console.WriteLine($"Introdueix {Const.Stats[i]} de {namesArray[j]} ({Const.HardStats[i, j]} - {Const.EasyStats[i, j]})");
                                            else
                                                Console.WriteLine($"Introdueix {Const.Stats[i]} de {namesArray[j]} ({Const.EasyStats[i, j]} - {Const.HardStats[i, j]})");
                                            stats[i, j] = Convert.ToDouble(Console.ReadLine());
                                            errors += Class2.ErrorTester(stats, i, j);
                                            if (errors == 3)
                                            {
                                                Console.WriteLine(Const.BlankLine);
                                                Console.WriteLine(Const.RandomValueInsertion);
                                                Console.WriteLine(Const.BlankLine);
                                                if (Const.EasyStats[i, j] > Const.HardStats[i, j])
                                                    stats[i, j] = random.NextDouble() * (Const.EasyStats[i, j] - Const.HardStats[i, j]) + Const.HardStats[i, j];
                                                else
                                                    stats[i, j] = random.NextDouble() * (Const.HardStats[i, j] - Const.EasyStats[i, j]) + Const.EasyStats[i, j];
                                            }

                                        }

                                    }
                                }

                                break;
                            default:
                                errors++;
                                break;
                        }
                        Console.ReadKey();
                    } while (errors != Const.Three && (difficulty < Const.Zero || difficulty > Const.Four));
                }
                Class2.ErrorTester(errors);
            }

        }
    }
}
