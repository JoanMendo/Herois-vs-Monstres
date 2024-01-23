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
            double[] HPSorted = new double[Const.Four];
            string names;
            int action;
            string[] namesArray;
            int round;
            Random random = new Random();
            int[] randomTurns = {Const.Zero,Const.One,Const.Two,Const.Three};
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

                                            stats[j, i] = Math.Round(stats[j, i], Const.Two);
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
                            errors = Const.Zero;
                            round++;
                            Console.WriteLine($"Ronda {round}");
                            Console.WriteLine(Const.BlankLine);
                            random.Shuffle(randomTurns);
                            for (int i = Const.Zero; i < randomTurns.Length; i++)
                            {
                                if (HabilityCoolDowns[i] != Const.Zero)
                                    HabilityCoolDowns[i]--;
                            }
                            for (int i = Const.Zero; i < Const.Four; i++)
                            {
                                if (errors == Const.Three)
                                {
                                    Console.WriteLine(Const.NoTurn);
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
                                            case Const.One:
                                                critOrDodge = random.Next(Const.One, Const.Twenty);
                                            


                                                if (critOrDodge == Const.Two || critOrDodge == Const.Three)
                                                {
                                                    stats[Const.Zero, Const.Four] = stats[Const.Zero, Const.Four] - (Const.Two*(stats[Const.One, i] * (Const.One - (stats[Const.Two, Const.Four] / Const.OneHundred))));
                                                }
                                                else if (critOrDodge != Const.One)
                                                {
                                                    stats[Const.Zero, Const.Four] = stats[Const.Zero, Const.Four] - (stats[Const.One, i] * (Const.One - (stats[Const.Two, Const.Four] / Const.OneHundred)));
                                                }

                                                if (critOrDodge == Const.One)
                                                {
                                                    Console.WriteLine(Const.FailedAttack);
                                                } 
                                                else if (stats[Const.Zero, Const.Four] <= Const.Zero)
                                                {
                                                    Console.WriteLine($"{names[randomTurns[i]]} ha atacat al monstre {names[Const.Four]} i l'ha matat.");
                                                    Console.WriteLine(Const.BlankLine);
                                                    monsterDead = true;
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"{names[randomTurns[i]]} ha atacat al monstre {names[Const.Four]} i l'ha deixat a {stats[Const.Zero, Const.Four]} de vida.");
                                                    Console.Write(Const.BlankLine);
                                                }
                                            
                                                break;

                                            case Const.Two:
                                                DamagedReducedActive[randomTurns[i]] = true;
                                                Console.WriteLine($"{names[randomTurns[i]]} s'ha defensat i reduirà el dany rebut a la meitat en el següent atac.");
                                                break;

                                            case Const.Three:
                                                if (HabilityCoolDowns[randomTurns[i]] == Const.Zero)
                                                {
                                                    switch (randomTurns[i])
                                                    {
                                                        case Const.Zero:
                                                            monsterStuned = Const.Two;
                                                            archerHability = Const.Five;
                                                            Console.WriteLine(Const.ArcherStun);
                                                            Console.Write(Const.BlankLine);
                                                            break;
                                                        case Const.One:
                                                            knightHability = Const.Five;
                                                            knightInvincible = Const.Five;
                                                            Console.WriteLine(Const.KnightHability);
                                                            Console.WriteLine(Const.BlankLine);
                                                            break;
                                                        case Const.Two:
                                                            stats[Const.Zero, Const.Four] = stats[Const.Zero, Const.Four] - (stats[Const.One, Const.Two] * Const.Three * (Const.One-(stats[Const.Two, Const.Four] / Const.OneHundred)));
                                                            mageHability = Const.Five;
                                                            if (stats[Const.Zero, Const.Four] <= Const.Zero)
                                                            {
                                                                Console.WriteLine($"{names[randomTurns[i]]} ha llançat una bola de foc al monstre {names[Const.Four]} i l'ha matat.");
                                                                Console.WriteLine(Const.BlankLine);
                                                                monsterDead = true;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"{names[randomTurns[i]]} ha llançat una bola de foc al monstre {names[Const.Four]} i l'ha deixat a {stats[Const.Zero, Const.Four]} de vida.");
                                                                Console.WriteLine(Const.BlankLine);
                                                            }
                                                            break;
                                                        case Const.Three:
                                                            stats = Class2.DruidHealing(stats, namesArray);
                                                            druidHability = Const.Five;
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
                            if (monsterStuned != Const.Zero)
                            {
                                monsterStuned--;
                                Console.WriteLine(Const.MonsterStuned);
                            }
                            else
                            {
                                Console.WriteLine(Const.MonsterAttacks);
                                for (int i = Const.Zero; i < Const.Four; i++)
                                {
                                    if (randomTurns[i] == Const.One && knightInvincible != Const.Zero)
                                    {
                                        Console.WriteLine(Const.KnightInvulnerable);
                                    }
                                    else if (DamagedReducedActive[randomTurns[i]])
                                    stats[Const.Zero, i] = stats[Const.Zero, i] - (stats[Const.One, Const.Four] * (Const.One-(stats[Const.Two, i] / Const.OneHundred * Const.Two)));
                               
                                    else
                                    stats[Const.Zero, i] = stats[Const.Zero, i] - (stats[Const.One, Const.Four] * (Const.One-stats[Const.Two, i] / Const.OneHundred));

                                    HPSorted[i] = stats[Const.Zero, i];
                                }

                            
                                HPSorted = Class2.BubbleSortHP(HPSorted);
                            

                                for (int i = Const.Zero; i < Const.Four; i++)
                                {
                                    if (stats[Const.Zero, i] <= Const.Zero)
                                    {
                                        Console.WriteLine($"{names[randomTurns[i]]} esta al cementiri.");
                                        stats[Const.Zero, i] = Const.Zero;
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
