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
            int monsterStuned = Const.Zero;
            int knightInvincible = Const.Zero;
            int archerHability = Const.Zero;
            int knightHability = Const.Zero;
            int mageHability = Const.Zero;
            int druidHability = Const.Zero;
            bool monsterDead = false;
            int [] HabilityCoolDowns = {archerHability, knightHability, mageHability, druidHability};
            double[,] stats = new double[3, 5];
            string names;
            int action = Const.Zero;
            string[] namesArray;
            int round = 0;
            Random random = new Random();
            int[] randomTurns = {0,1,2,3};
            bool characterAlive = true;



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

            if (errors == Const.Three)
            {
                Console.WriteLine(Const.MenuErrorLeave);

            }

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

                if (errors == Const.Three)
                {
                    Console.WriteLine(Const.MenuErrorLeave);

                }
                else
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
                            case Const.One:
                                stats = Const.EasyStats;
                                break;
                            case Const.Two:
                                stats = Const.HardStats;
                                break;
                            case Const.Three:
                                for (int i = Const.Zero; i < Const.Five; i++)
                                {
                                    for (int j = Const.One; j < Const.Three; j++)
                                    {
                                        if (Const.EasyStats[j, i] > Const.HardStats[j, i])
                                            stats[j, i] = random.NextDouble() * (Const.EasyStats[j, i] - Const.HardStats[j, i]) + Const.HardStats[j, i];
                                        
                                        else
                                            stats[j, i] = random.NextDouble() * (Const.HardStats[j, i] - Const.EasyStats[j, i]) + Const.EasyStats[j, i];

                                        stats[j, i] = Math.Round(stats[j, i], 2);
                                    }
                                }
                                break;
                            case Const.Four:
                                for (int i = Const.Zero; i < Const.Three; i++)
                                {
                                    for (int j = Const.Zero; j < Const.Five; j++)
                                    {
                                        errors = Const.Zero;
                                        do
                                        {
                                            if (Const.EasyStats[i, j] > Const.HardStats[i, j])
                                            {
                                                Console.WriteLine(Const.BlankLine);
                                                Console.WriteLine($"Introdueix {Const.Stats[i]} de {namesArray[j]} ({Const.HardStats[i, j]} - {Const.EasyStats[i, j]})");
                                                Console.WriteLine(Const.BlankLine);
                                            }                                              
                                            else
                                            {
                                                Console.WriteLine(Const.BlankLine);
                                                Console.WriteLine($"Introdueix {Const.Stats[i]} de {namesArray[j]} ({Const.EasyStats[i, j]} - {Const.HardStats[i, j]})");
                                                Console.WriteLine(Const.BlankLine);
                                            }
                                            stats[i, j] = Convert.ToDouble(Console.ReadLine());
                                            if (Class2.ErrorTester(stats, i, j) == true)
                                            {
                                                
                                                Console.WriteLine(Const.ErrorInValue);
                                                Console.WriteLine(Const.BlankLine);
                                                errors++;                                            
                                            }
                                            if (errors == Const.Three)
                                            {
                                                Console.WriteLine(Const.BlankLine);
                                                Console.WriteLine(Const.RandomValueInsertion);
                                                Console.WriteLine(Const.BlankLine);
                                                if (Const.EasyStats[i, j] > Const.HardStats[i, j])
                                                    stats[i, j] = Const.HardStats[i, j];
                                                else
                                                    stats[i, j] =  Const.EasyStats[i, j];
                                            }
                                        } while (errors != Const.Three && Class2.ErrorTester(stats, i, j) == true);
                                    }
                                }
                                break;
                            default:
                                errors++;
                                break;
                        }
                        
                    } while (errors != Const.Three && (difficulty < Const.Zero || difficulty > Const.Four));
                }
                if (errors == Const.Three)
                {
                    Console.WriteLine(Const.MenuErrorLeave);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    do
                    {
                        errors = 0;
                        round++;
                        Console.WriteLine($"Ronda {round}");
                        random.Shuffle(randomTurns);
                        for (int i = 0; i < 4; i++)
                        {
                            if (errors == Const.Three)
                            {
                                Console.WriteLine("Et quedas sense torn per inútil.");
                                errors = Const.Zero;
                            }
                            if (errors != Const.Zero)
                                i--;
                            
                            characterAlive = Class2.CharactersAliveTester(randomTurns[i], namesArray, stats);
                            if (characterAlive == true)
                            {
                                action = Convert.ToInt32(Console.ReadLine());
                                if (Class2.ErrorTester(action))
                                {
                                    switch (action)
                                    {
                                        case 1:
                                            stats[0, 4] = stats[0, 4] - (stats[1,i] * (stats[2,4] / 100));
                                            if (stats[0, 4] <= 0)
                                            {
                                                Console.WriteLine($"{names[i]} ha atacat al monstre {names[4]} i l'ha matat.");
                                                monsterDead = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine($"{names[i]} ha atacat al monstre {names[4]} i l'ha deixat a stats[0, 4] de vida.");
                                            }
                                            
                                            break;

                                        case 2:
                                            break;

                                        case 3:
                                            break;
                                    }
                                }
                                else
                                {
                                    errors++;
                                }
                            }
                            
                        }
                        if (monsterStuned != 0)
                        {
                            monsterStuned--;
                            Console.WriteLine("El monstre està stuneat i no atacarà");
                        }
                        else
                        {

                        }
                        
                    } while (characterAlive == true);
                    
                }
            }

        }
    }
}
