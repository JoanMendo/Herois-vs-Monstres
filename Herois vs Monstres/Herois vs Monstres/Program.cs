using Constants;
using Metodos;

namespace PR1
{
    public class Si
    {
        public static void Main()
        {
            int critOrDodge;
            int errors;
            int initialAnswer;
            int stayOrLeave;
            int difficulty;
            int monsterStuned;
            int knightInvincible;
            int archerHability = Const.Zero;
            int knightHability = Const.Zero;
            int mageHability = Const.Zero;
            int druidHability = Const.Zero;
            int [] HabilityCoolDowns = {archerHability, knightHability, mageHability, druidHability};
            bool damageReducedArcher = false;
            bool damageReducedKnight = false;
            bool damageReducedMage = false;
            bool damageReducedDruid = false;
            bool[] DamagedReducedActive = { damageReducedArcher, damageReducedKnight, damageReducedMage, damageReducedDruid };
            double[,] stats = new double[3, 5];
            double[] HPSorted = new double[4];
            string names;
            int action;
            string[] namesArray;
            int round;
            Random random = new Random();
            int[] randomTurns = {0,1,2,3};
            bool characterAlive;
            bool monsterDead;


            do
            {
                critOrDodge = Const.Zero;
                errors = Const.Zero;
                initialAnswer = Const.Zero;
                stayOrLeave = Const.Zero;
                difficulty = Const.Zero;
                monsterStuned = Const.Zero;
                knightInvincible = Const.Zero;
                archerHability = Const.Zero;
                knightHability = Const.Zero;
                mageHability = Const.Zero;
                druidHability = Const.Zero;
                damageReducedArcher = false;
                damageReducedKnight = false;
                damageReducedMage = false;
                damageReducedDruid = false;
                action = Const.Zero;
                round = Const.Zero;
                characterAlive = true;
                monsterDead = false;



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
                        Console.WriteLine(Const.BlankLine);
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
                        Console.WriteLine(Const.BlankLine);
                        Console.WriteLine(Const.BlankLine);
                        Console.WriteLine(Const.BlankLine);
                        Console.WriteLine(Const.BattleStart);
                        Console.WriteLine(Const.BlankLine);
                        do
                        {
                            damageReducedArcher = false;
                            damageReducedKnight = false;
                            damageReducedMage = false;
                            damageReducedDruid = false;
                            errors = 0;
                            round++;
                            Console.WriteLine($"Ronda {round}");
                            Console.WriteLine(Const.BlankLine);
                            random.Shuffle(randomTurns);
                            for (int i = 0; i < randomTurns.Length; i++)
                            {
                                if (HabilityCoolDowns[i] != 0)
                                    HabilityCoolDowns[i]--;
                            }
                            for (int i = 0; i < 4; i++)
                            {
                                if (errors == Const.Three)
                                {
                                    Console.WriteLine("Et quedas sense torn per inútil.");
                                    Console.WriteLine(Const.BlankLine);
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
                                                critOrDodge = random.Next(1, 20);
                                            


                                                if (critOrDodge == 2 || critOrDodge == 3)
                                                {
                                                    stats[0, 4] = stats[0, 4] - (2*(stats[1, i] * (1 - (stats[2, 4] / 100))));
                                                }
                                                else if (critOrDodge != 1)
                                                {
                                                    stats[0, 4] = stats[0, 4] - (stats[1, i] * (1 - (stats[2, 4] / 100)));
                                                }

                                                if (critOrDodge == 1)
                                                {
                                                    Console.WriteLine("El teu personatge és inutil i ha fallat l'atac");
                                                } 
                                                else if (stats[0, 4] <= 0)
                                                {
                                                    Console.WriteLine($"{names[randomTurns[i]]} ha atacat al monstre {names[4]} i l'ha matat.");
                                                    Console.WriteLine(Const.BlankLine);
                                                    monsterDead = true;
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"{names[randomTurns[i]]} ha atacat al monstre {names[4]} i l'ha deixat a {stats[0, 4]} de vida.");
                                                    Console.Write(Const.BlankLine);
                                                }
                                            
                                                break;

                                            case 2:
                                                DamagedReducedActive[randomTurns[i]] = true;
                                                Console.WriteLine($"{names[randomTurns[i]]} s'ha defensat i reduirà el dany rebut a la meitat en el següent atac.");
                                                break;

                                            case 3:
                                                if (HabilityCoolDowns[randomTurns[i]] == 0)
                                                {
                                                    switch (randomTurns[i])
                                                    {
                                                        case 0:
                                                            monsterStuned = 2;
                                                            archerHability = 5;
                                                            Console.WriteLine(Const.ArcherStun);
                                                            Console.Write(Const.BlankLine);
                                                            break;
                                                        case 1:
                                                            knightHability = 5;
                                                            knightInvincible = 3;
                                                            Console.WriteLine(Const.KnightHability);
                                                            Console.WriteLine(Const.BlankLine);
                                                            break;
                                                        case 2:
                                                            stats[0, 4] = stats[0, 4] - (stats[1, 2] * 3 * (1-(stats[2, 4] / 100)));
                                                            mageHability = 5;
                                                            if (stats[0, 4] <= 0)
                                                            {
                                                                Console.WriteLine($"{names[randomTurns[i]]} ha llançat una bola de foc al monstre {names[4]} i l'ha matat.");
                                                                Console.WriteLine(Const.BlankLine);
                                                                monsterDead = true;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"{names[randomTurns[i]]} ha llançat una bola de foc al monstre {names[4]} i l'ha deixat a {stats[0, 4]} de vida.");
                                                                Console.WriteLine(Const.BlankLine);
                                                            }
                                                            break;
                                                        case 3:
                                                            stats = Class2.DruidHealing(stats, namesArray);
                                                            druidHability = 5;
                                                            Console.WriteLine(Const.KnightHability);
                                                            Console.WriteLine(Const.BlankLine);
                                                            break;
                                                    }    
                                                
                                                }
                                                else
                                                {
                                                    Console.WriteLine(Const.HabilityOnCooldown);
                                                    Console.WriteLine(Const.BlankLine);
                                                    errors++;
                                                }
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
                                Console.WriteLine($"El monstre acaba d'atacar");
                                for (int i = 0; i < 4; i++)
                                {
                                    if (randomTurns[i] == 1 && knightInvincible != 0)
                                    {
                                        Console.WriteLine(Const.KnightInvulnerable);
                                    }
                                    else if (DamagedReducedActive[randomTurns[i]])
                                    stats[0, i] = stats[0, i] - (stats[1, 4] * (1-(stats[2, i] / 100 * 2)));
                               
                                    else
                                    stats[0, i] = stats[0, i] - (stats[1, 4] * (1-stats[2, i] / 100));

                                    HPSorted[i] = stats[0, i];
                                }

                            
                                HPSorted = Class2.BubbleSortHP(HPSorted);
                            

                                for (int i = 0; i < 4; i++)
                                {
                                    if (stats[0, i] <= 0)
                                    {
                                        Console.WriteLine($"{names[randomTurns[i]]} esta al cementiri.");
                                        stats[0, i] = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{names[randomTurns[i]]} ha quedat a {HPSorted[i]} de vida.");
                                    }
                                }
                            
                            }
                        
                        } while (characterAlive == true);
                        if (monsterDead == true)
                        {
                            Console.WriteLine(Const.MonsterDefeated);
                            Console.WriteLine(Const.BlankLine);
                            Console.WriteLine(Const.MenuReturn);
                            Console.WriteLine(Const.BlankLine);
                        }
                        else
                        {
                            Console.WriteLine(Const.HeroesDefeated);
                            Console.WriteLine(Const.BlankLine);
                            Console.WriteLine(Const.MenuReturn);
                            Console.WriteLine(Const.BlankLine);
                        }
                    
                    }
                }
            } while (stayOrLeave != Const.Zero);

        }
    }
}
