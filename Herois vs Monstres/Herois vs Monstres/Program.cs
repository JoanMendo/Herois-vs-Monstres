using System;
using System.Threading;

namespace PR1
{
    public class si
    {
        public static void Main()
        {
            /* Definició de constants i variables*/
            const string StartingMsg = "Benvingut a Herois vs Monstres!";
            const string StartLeave = "Que vols fer ?";
            const string HowToPlay = "1. Jugar a aquesta obra maestra del gaming";
            const string HowToLeave = "0. Tancar el programa";
            const string StartError = "Tens que escriure 0 per sortir del programa, o 1 per jugar, no és tan dificil.";
            const string MenuErrorLeave = "Bueno, si no etc capaç ni de començar a jugar, no continuis.";
            const string Leave = "Estas segur de que vols marchar? Aquest joc es molt divertit, prem 0 només si estas segur de que no vols jugar. Va, prem 1.";
            const string LeaveConfirmed = "Bueno, donç moltes gràcies per apofitar d'aquesta manera les hores que he invertit creant això. Que tinguis un mal dia.";
            const string BackToMenu = "Total d'errors assolits, retornant al menú";

            const string StartToCreate = "Primer toca definir las estadístiques dels personatges, dins del rang que s'especificarà dins de [] Si et surts del limit 3 cops, tornaras a l'inici de crear el personatge. Si això passa 3 cops, tornaras al menú.";
            const string StartArcher = "El primer personatge és l'arquera.";
            const string StartKnight = "El segon personatge és el cavaller.";
            const string StartSorcerer = "El tercer personatge és la maga.";
            const string StartDruid = "El quart personatge és el druida.";
            const string StartMonster = "Finalment, el monstre.";
            const string ErrorInValue = "Has d'introduir un nombre que estigui dins de l'interval especificat.";
            const string RetryValueInsertion = "Torna a introduir les dades d'aquest personatge.";

            const string ArcherHP = "Introdueix la vida que tindrà l'arquera [1500-2000]";
            const string KnightHP = "Introdueix la vida que tindrà el cavaller [3000-3750]";
            const string SorcererHP = "Introdueix la vida que tindrà la maga [1000-1500]";
            const string DruidHP = "Introdueix la vida que tindrà el druida [2000-2500]";
            const string MonsterHP = "Introdueix la vida que tindrà el monstre [9000-12000]";

            const string ArcherDmg = "Introdueix l'atac que tindrà l'arquera [180-300]";
            const string KnightDmg = "Introdueix l'atac  que tindrà el cavaller [150-250]";
            const string SorcererDmg = "Introdueix l'atac que tindrà la maga [300-350]";
            const string DruidDmg = "Introdueix l'atac que tindrà el druida [70-120]";
            const string MonsterDmg = "Introdueix l'atac que tindrà el monstre [250-400]";

            const string ArcherDmgReduction = "Introdueix la reducció de dany que tindrà l'arquera [25-40]%";
            const string KnightDmgReduction = "Introdueix la reducció de dany que tindrà el cavaller [35-45]%";
            const string SorcererDmgReduction = "Introdueix la reducció de dany que tindrà la maga [20-35]%";
            const string DruidDmgReduction = "Introdueix la reducció de dany que tindrà el druida [25-40]%";
            const string MonsterDmgReduction = "Introdueix la reducció de dany que tindrà el monstre [20-30]%";

            const string BattleStart = "Comença la batalla conta el monstre. Recorda que les habilitats dels personatges tenen un cooldown de 5 torns, i que fer 3 errors al seleccionar l'ació d'un personatge et retornarà al menú. ";
            const string ArcherTurn = "És el torn de l'arquera";
            const string KnightTurn = "És el torn del cavaller";
            const string SorcererTurn = "És el torn de la maga";
            const string DruidTurn = "És el torn del druida";
            const string Attack = "1. Atacar al monstre";
            const string Defense = "2. Defensarse (Duplica la reducció de dany aquest torn)";
            const string DefenseArcher = "L'arquera es defensarà aquest torn.";
            const string DefenseKnight = "El cavaller es defensarà aquest torn";
            const string DefenseSorcerer = "La maga es defensarà aquesta ronda";
            const string DefenseDruid = "El druida es defensarà aquesta ronda";
            const string HabilityArcher = "3. Stunea al monstre durant 2 torns";
            const string HabilityKnight = "3. El cavaller es torna invulnerable al dany durant 3 torns";
            const string HabilitySorcerer = "3. Lança una bola de foc al monstre que fa el triple de dany que l'atac normal de la maga";
            const string HabilityDruid = "3. Retorna 500 de vida als teus aliats. No pot sobrepasar la seva vida màxima";
            const string CombatError = "1 per atacar, 2 per defensar-se, 3 per l'abilitat, no és tan difícil.";
            const string MonsterDefeated = "Felicitats, has acabat amb el monstre";
            const string ArcherDead = "La arquera s'acaba de morir";
            const string KnightDead = "El cavaller s'acaba de morir";
            const string SorcererDead = "La maga s'acaba de morir";
            const string DruidDead = "El druida s'acaba de morir";
            const string ArcherStun = "L'arquera a stunejat al monstre durant 2 turns";
            const string HabilityOnCooldown = "Aquesta habilitat està en cooldown";
            const string MonsterStuned = "El monstre està stunejat i no atacarà aquest torn";
            const string KnightHability = "El cavaller  es protegeix, i serà invulnerabble al dany durant tres torns";
            const string KnightHabilityActive = "El monstre ataca al cavaller, pero al cavaller se la pela tot";
            const string KnightDefendWhileabilityActive = "Això no ha servit de res perquè igualment no habria rebut dany, però no et desanimis campió";

            const string BlankLine = " ";

            const decimal Zero = 0;
            const decimal One = 1;
            const decimal Two = 2;
            const decimal Three = 3;
            const decimal Five = 5;
            const decimal Twenty = 20;
            const decimal Thirty = 30;
            const decimal Seventy = 70;
            const decimal OneHundred = 100;
            const decimal OneHundredAndTwenty = 120;
            const decimal FiveHundred = 500;
            const decimal OneThousandFiveHundred = 1500;
            const decimal TwoThousand = 2000;
            const decimal TwoThousandAndFiveHundred = 2500;
            const decimal OneHundredAndEighty = 180;
            const decimal ThreeHundred = 300;
            const decimal TwentyFive = 25;
            const decimal Forty = 40;
            const decimal ThreeThousand = 3000;
            const decimal ThreeThousandSevenHundredSeventyFive = 3750;
            const decimal OneHundredAndFifty = 150;
            const decimal TwoHundredAndFifty = 250;
            const decimal FourHundred = 400;
            const decimal ThirtyFive = 35;
            const decimal FortyFive = 45;
            const decimal OneThousand = 1000;
            const decimal ThreeHundredAndFifty = 350;
            const decimal NineThousand = 9000;
            const decimal TwelveThousand = 12000;


            decimal menuErrors = Zero;
            decimal totalErrors = Zero;
            decimal startGame = One;
            decimal leave = One;
            decimal errorsInStat = Zero;
            decimal errorsInCharacter = Zero;
            decimal archerHP = Zero, knightHP = Zero, sorcererHP = Zero, druidHP = Zero, monsterHP = Zero;
            decimal archerMaxHP = Zero, knightMaxHP = Zero, sorcererMaxHP = Zero, druidMaxHP = Zero;
            decimal archerDmg = Zero, knightDmg = Zero, sorcererDmg = Zero, druidDmg = Zero, monsterDmg = Zero;
            decimal archerDmgReduction = Zero, knightDmgReduction = Zero, sorcererDmgReduction = Zero, druidDmgReduction = Zero, monsterDmgReduction = Zero;


            decimal errorsInBattle = Zero;
            bool archerDead = false, knightDead = false, sorcererDead = false, druidDead = false, monsterDead = false;
            bool archerDefended = false, knightDefended = false, sorcererDefended = false, druidDefended = false;
            decimal archerCooldown = Zero, knightCooldown = Zero, sorcererCooldown = Zero, druidCooldown = Zero;
            bool firstHabilityArcher = true, firstHabilityKnight = true, firstHabilitySorcerer = true, firstHabilityDruid = true;
            decimal currentTurn = One;
            decimal currentAction = Zero;
            decimal damageDealt = Zero;
            bool characterTurnEnded = false;
            bool monsterStuned = false;
            decimal stunDuration = Two;
            decimal knightHability = Three;

            bool repeatStats = false;
            bool archerCreationCorrect = false, knightCreationCorrect = false, sorcererCreationCorrect = false, druidCreationCorrect = false, monsterCreationCorrect = false;

            Console.WriteLine(StartingMsg);

            while (startGame == One && leave == One) /* Bucle per a que el programa se repeteixi */
            {
                errorsInCharacter = Zero;
                errorsInBattle = Zero;
                archerCreationCorrect = false;
                knightCreationCorrect = false;
                sorcererCreationCorrect = false;
                druidCreationCorrect = false;
                monsterCreationCorrect = false;
                firstHabilityArcher = true;
                firstHabilityKnight = true;
                firstHabilitySorcerer = true;
                firstHabilityDruid = true;

                archerDead = false;
                knightDead = false;
                sorcererDead = false;
                druidDead = false;
                monsterDead = false;
                currentTurn = One;
                monsterStuned = false;
                stunDuration = Two;

                Console.WriteLine(StartLeave); /*Missatge inicial*/

                while (menuErrors < Three)  /*Bucle per a poder fer 3 errors al menú*/
                {
                    Console.WriteLine(HowToLeave);
                    Console.WriteLine(HowToPlay);
                    startGame = Convert.ToDecimal(Console.ReadLine());
                    leave = Zero;

                    if (startGame == Zero)
                    {
                        Console.WriteLine(BlankLine);
                        Console.WriteLine(Leave);  /*Missatge per a confirmar la sortida del programa*/
                        leave = Convert.ToDecimal(Console.ReadLine());
                        if (leave == Zero)
                        {
                            Console.WriteLine(LeaveConfirmed);
                            menuErrors = Three;
                            totalErrors = Three;
                        }
                        else
                            startGame = One;
                    }
                    if ((startGame != One && startGame != Zero) || (leave != One && leave != Zero)) /*Codi en cas d'error al menú*/
                    {
                        Console.WriteLine(StartError);
                        menuErrors++;
                        totalErrors++;
                        if (menuErrors == Three)
                            Console.WriteLine(MenuErrorLeave); /*Missatge d'expulsió per errors*/
                    }
                    else
                    {
                        totalErrors = menuErrors;
                        menuErrors = Three;
                    }
                }

                if (totalErrors < Three) /* Condicional que només inicia el programa si hi han menos de 3 errors al menú*/
                {
                    menuErrors = Zero;
                    totalErrors = Zero;
                    Console.WriteLine(BlankLine);
                    Console.WriteLine(StartToCreate);

                    while (errorsInCharacter < Three) /*Bucle per a la creacio de personatges*/
                    {
                        errorsInStat = Zero;
                        repeatStats = false;
                        if (archerCreationCorrect == false)
                        {
                            Console.WriteLine(BlankLine);
                            Console.WriteLine(StartArcher);
                            while (errorsInStat < Three && repeatStats == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(ArcherHP);
                                archerHP = Convert.ToDecimal(Console.ReadLine());
                                if (archerHP >= OneThousandFiveHundred && archerHP <= TwoThousand)
                                    errorsInStat = Three;
                                else
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(ErrorInValue);
                                    errorsInStat++;
                                    if (errorsInStat == Three)
                                    {
                                        errorsInCharacter++;
                                        repeatStats = true;
                                        if (errorsInCharacter < Three)
                                            Console.WriteLine(RetryValueInsertion);
                                    }


                                }
                            }
                            errorsInStat = Zero;
                            while (errorsInStat < Three && repeatStats == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(ArcherDmg);
                                archerDmg = Convert.ToDecimal(Console.ReadLine());
                                if (archerDmg >= OneHundredAndEighty && archerDmg <= ThreeHundred)
                                    errorsInStat = Three;
                                else
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(ErrorInValue);
                                    errorsInStat++;
                                    if (errorsInStat == Three)
                                    {
                                        errorsInCharacter++;
                                        repeatStats = true;
                                        if (errorsInCharacter < Three)
                                            Console.WriteLine(RetryValueInsertion);
                                    }
                                }
                            }
                            errorsInStat = Zero;
                            while (errorsInStat < Three && repeatStats == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(ArcherDmgReduction);
                                archerDmgReduction = Convert.ToDecimal(Console.ReadLine());
                                if (archerDmgReduction >= TwentyFive && archerDmgReduction <= Forty)
                                {
                                    errorsInStat = Three;
                                }
                                else
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(ErrorInValue);
                                    errorsInStat++;
                                    if (errorsInStat == Three)
                                    {
                                        errorsInCharacter++;
                                        repeatStats = true;
                                        if (errorsInCharacter < Three)
                                            Console.WriteLine(RetryValueInsertion);
                                    }
                                }
                            }
                        }

                        if (repeatStats == false)
                        {
                            errorsInStat = Zero;
                            archerCreationCorrect = true;
                        } /*Això asegura que si es reinicia la creació d'un personatge no es comença desde el primer personatge sino desde en el que estaves*/

                        if (knightCreationCorrect == false && archerCreationCorrect == true)
                        {
                            Console.WriteLine(BlankLine);
                            Console.WriteLine(StartKnight);
                            while (errorsInStat < Three && repeatStats == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(KnightHP);
                                knightHP = Convert.ToDecimal(Console.ReadLine());
                                if (knightHP >= ThreeThousand && knightHP <= ThreeThousandSevenHundredSeventyFive)
                                    errorsInStat = Three;
                                else
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(ErrorInValue);
                                    errorsInStat++;
                                    if (errorsInStat == Three)
                                    {
                                        errorsInCharacter++;
                                        repeatStats = true;
                                        if (errorsInCharacter < Three)
                                            Console.WriteLine(RetryValueInsertion);
                                    }
                                }
                            }
                            errorsInStat = Zero;
                            while (errorsInStat < Three && repeatStats == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(KnightDmg);
                                knightDmg = Convert.ToDecimal(Console.ReadLine());
                                if (knightDmg >= OneHundredAndFifty && knightDmg <= TwoHundredAndFifty)
                                    errorsInStat = Three;
                                else
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(ErrorInValue);
                                    errorsInStat++;
                                    if (errorsInStat == Three)
                                    {
                                        errorsInCharacter++;
                                        repeatStats = true;
                                        if (errorsInCharacter < Three)
                                            Console.WriteLine(RetryValueInsertion);
                                    }


                                }
                            }
                            errorsInStat = Zero;
                            while (errorsInStat < Three && repeatStats == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(KnightDmgReduction);
                                knightDmgReduction = Convert.ToDecimal(Console.ReadLine());
                                if (knightDmgReduction >= ThirtyFive && knightDmgReduction <= FortyFive)
                                {
                                    errorsInStat = Three;
                                }
                                else
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(ErrorInValue);
                                    errorsInStat++;
                                    if (errorsInStat == Three)
                                    {
                                        errorsInCharacter++;
                                        repeatStats = true;
                                        if (errorsInCharacter < Three)
                                            Console.WriteLine(RetryValueInsertion);
                                    }


                                }
                            }
                        }

                        if (repeatStats == false)
                        {
                            errorsInStat = Zero;
                            knightCreationCorrect = true;
                        }

                        if (sorcererCreationCorrect == false && knightCreationCorrect == true)
                        {
                            Console.WriteLine(BlankLine);
                            Console.WriteLine(StartSorcerer);
                            while (errorsInStat < Three && repeatStats == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(SorcererHP);
                                sorcererHP = Convert.ToDecimal(Console.ReadLine());
                                if (sorcererHP >= OneThousand && sorcererHP <= OneThousandFiveHundred)
                                    errorsInStat = Three;
                                else
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(ErrorInValue);
                                    errorsInStat++;
                                    if (errorsInStat == Three)
                                    {
                                        errorsInCharacter++;
                                        repeatStats = true;
                                        if (errorsInCharacter < Three)
                                            Console.WriteLine(RetryValueInsertion);
                                    }
                                }
                            }
                            errorsInStat = Zero;
                            while (errorsInStat < Three && repeatStats == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(SorcererDmg);
                                sorcererDmg = Convert.ToDecimal(Console.ReadLine());
                                if (sorcererDmg >= ThreeHundred && sorcererDmg <= ThreeHundredAndFifty)
                                    errorsInStat = Three;
                                else
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(ErrorInValue);
                                    errorsInStat++;
                                    if (errorsInStat == Three)
                                    {
                                        errorsInCharacter++;
                                        repeatStats = true;
                                        if (errorsInCharacter < Three)
                                            Console.WriteLine(RetryValueInsertion);
                                    }


                                }
                            }
                            errorsInStat = Zero;
                            while (errorsInStat < Three && repeatStats == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(SorcererDmgReduction);
                                sorcererDmgReduction = Convert.ToDecimal(Console.ReadLine());
                                if (sorcererDmgReduction >= Twenty && sorcererDmgReduction <= ThirtyFive)
                                {
                                    errorsInStat = Three;
                                }
                                else
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(ErrorInValue);
                                    errorsInStat++;
                                    if (errorsInStat == Three)
                                    {
                                        errorsInCharacter++;
                                        repeatStats = true;
                                        if (errorsInCharacter < Three)
                                            Console.WriteLine(RetryValueInsertion);
                                    }
                                }
                            }
                        }

                        if (repeatStats == false)
                        {
                            errorsInStat = Zero;
                            sorcererCreationCorrect = true;
                        }

                        if (druidCreationCorrect == false && sorcererCreationCorrect == true)
                        {
                            Console.WriteLine(BlankLine);
                            Console.WriteLine(StartDruid);
                            while (errorsInStat < Three && repeatStats == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(DruidHP);
                                druidHP = Convert.ToDecimal(Console.ReadLine());
                                if (druidHP >= TwoThousand && druidHP <= TwoThousandAndFiveHundred)
                                    errorsInStat = Three;
                                else
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(ErrorInValue);
                                    errorsInStat++;
                                    if (errorsInStat == Three)
                                    {
                                        errorsInCharacter++;
                                        repeatStats = true;
                                        if (errorsInCharacter < Three)
                                            Console.WriteLine(RetryValueInsertion);
                                    }
                                }
                            }
                            errorsInStat = Zero;
                            while (errorsInStat < Three && repeatStats == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(DruidDmg);
                                druidDmg = Convert.ToDecimal(Console.ReadLine());
                                if (druidDmg >= Seventy && druidDmg <= OneHundredAndTwenty)
                                    errorsInStat = Three;
                                else
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(ErrorInValue);
                                    errorsInStat++;
                                    if (errorsInStat == Three)
                                    {
                                        errorsInCharacter++;
                                        repeatStats = true;
                                        if (errorsInCharacter < Three)
                                            Console.WriteLine(RetryValueInsertion);
                                    }


                                }
                            }
                            errorsInStat = Zero;
                            while (errorsInStat < Three && repeatStats == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(DruidDmgReduction);
                                druidDmgReduction = Convert.ToDecimal(Console.ReadLine());
                                if (druidDmgReduction >= TwentyFive && druidDmgReduction <= Forty)
                                {
                                    errorsInStat = Three;
                                }
                                else
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(ErrorInValue);
                                    errorsInStat++;
                                    if (errorsInStat == Three)
                                    {
                                        errorsInCharacter++;
                                        repeatStats = true;
                                        if (errorsInCharacter < Three)
                                            Console.WriteLine(RetryValueInsertion);
                                    }
                                }
                            }
                        }


                        if (repeatStats == false)
                        {
                            errorsInStat = Zero;
                            druidCreationCorrect = true;
                        }

                        if (monsterCreationCorrect == false && druidCreationCorrect == true)
                        {
                            Console.WriteLine(BlankLine);
                            Console.WriteLine(StartMonster);
                            while (errorsInStat < Three && repeatStats == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(MonsterHP);
                                monsterHP = Convert.ToDecimal(Console.ReadLine());
                                if (monsterHP >= NineThousand && monsterHP <= TwelveThousand)
                                    errorsInStat = Three;
                                else
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(ErrorInValue);
                                    errorsInStat++;
                                    if (errorsInStat == Three)
                                    {
                                        errorsInCharacter++;
                                        repeatStats = true;
                                        if (errorsInCharacter < Three)
                                            Console.WriteLine(RetryValueInsertion);
                                    }
                                }
                            }
                            errorsInStat = Zero;
                            while (errorsInStat < Three && repeatStats == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(MonsterDmg);
                                monsterDmg = Convert.ToDecimal(Console.ReadLine());
                                if (monsterDmg >= TwoHundredAndFifty && monsterDmg <= FourHundred)
                                    errorsInStat = Three;
                                else
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(ErrorInValue);
                                    errorsInStat++;
                                    if (errorsInStat == Three)
                                    {
                                        errorsInCharacter++;
                                        repeatStats = true;
                                        if (errorsInCharacter < Three)
                                            Console.WriteLine(RetryValueInsertion);
                                    }


                                }
                            }
                            errorsInStat = Zero;
                            while (errorsInStat < Three && repeatStats == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(MonsterDmgReduction);
                                monsterDmgReduction = Convert.ToDecimal(Console.ReadLine());
                                if (monsterDmgReduction >= Twenty && monsterDmgReduction <= Thirty)
                                {
                                    errorsInStat = Three;
                                }
                                else
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(ErrorInValue);
                                    errorsInStat++;
                                    if (errorsInStat == Three)
                                    {
                                        errorsInCharacter++;
                                        repeatStats = true;
                                        if (errorsInCharacter < Three)
                                            Console.WriteLine(RetryValueInsertion);
                                    }
                                }
                            }
                        }
                        if (repeatStats == false)
                        {
                            errorsInStat = Zero;
                            monsterCreationCorrect = true;
                            errorsInCharacter = Three;
                        }
                    }
                    /* Ara comença la batalla per torns */
                    if (archerCreationCorrect == true && knightCreationCorrect == true && sorcererCreationCorrect == true && druidCreationCorrect == true && monsterCreationCorrect == true)
                    {
                        archerMaxHP = archerHP;
                        knightMaxHP = knightHP;
                        sorcererMaxHP = sorcererHP;
                        druidMaxHP = druidHP;
                        /*Es defineixen aquests atributs per a l'habilitat del durida*/

                        if (errorsInBattle < Three && (monsterDead == false && (archerDead == false || knightDead == false || sorcererDead == false || druidDead == false)))
                            Console.WriteLine(BattleStart); /*Missatge que només es mostra 1 cop al començar*/
                        while (errorsInBattle < Three && (monsterDead == false && (archerDead == false || knightDead == false || sorcererDead == false || druidDead == false)))
                        {
                            Console.WriteLine("Ronda " + currentTurn);
                            Console.WriteLine(BlankLine);
                            if (errorsInBattle != Three)
                            {
                                characterTurnEnded = false;
                                errorsInBattle = Zero;
                                /*Comproba que el bucle del combat es repeteixi excepte quan es fan 3 errors seguits, i reinicia els erros si s'han fet però han sigut menys de tres*/
                            }
                            if (archerDead == false && monsterDead == false && characterTurnEnded == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(ArcherTurn);
                                while (characterTurnEnded == false)
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(Attack);
                                    Console.WriteLine(Defense);
                                    Console.WriteLine(HabilityArcher);
                                    currentAction = Convert.ToDecimal(Console.ReadLine());
                                    switch (currentAction) /*Les accions d'atacar, defensar-se, o l'abilitat de cada personatge*/
                                    {
                                        case One:
                                            damageDealt = (archerDmg - archerDmg * (monsterDmgReduction / OneHundred));
                                            monsterHP -= damageDealt;
                                            Console.WriteLine(BlankLine);
                                            Console.WriteLine("L'arquera ha atacat al monstre fent-li " + damageDealt + " de dany.");
                                            characterTurnEnded = true;
                                            if (monsterHP < Zero)
                                            {
                                                monsterDead = true;
                                                Console.WriteLine(MonsterDefeated);
                                                break;
                                            }
                                            else
                                                Console.WriteLine("La vida actual del monstre és de " + monsterHP);
                                            break;
                                        case Two:
                                            archerDmgReduction = archerDmgReduction * Two;
                                            archerDefended = true;
                                            Console.WriteLine(DefenseArcher);
                                            characterTurnEnded = true;
                                            break;
                                        case Three:
                                            if (archerCooldown <= currentTurn || firstHabilityArcher == true)
                                            {
                                                Console.WriteLine(ArcherStun);
                                                monsterStuned = true;
                                                archerCooldown = currentTurn + Five;
                                                firstHabilityArcher = false;
                                                characterTurnEnded = true;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine(HabilityOnCooldown);
                                            }
                                            break;
                                        default:
                                            Console.WriteLine(CombatError);
                                            errorsInBattle++;
                                            if (errorsInBattle == Three)
                                                characterTurnEnded = true;
                                            break;

                                    }
                                }
                            }

                            if (errorsInBattle != Three)
                            {
                                characterTurnEnded = false;
                                errorsInBattle = Zero;
                            }



                            if (knightDead == false && monsterDead == false && characterTurnEnded == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(KnightTurn);
                                while (characterTurnEnded == false)
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(Attack);
                                    Console.WriteLine(Defense);
                                    Console.WriteLine(HabilityKnight);
                                    currentAction = Convert.ToDecimal(Console.ReadLine());
                                    switch (currentAction)
                                    {
                                        case One:
                                            damageDealt = (knightDmg - knightDmg * (monsterDmgReduction / OneHundred));
                                            monsterHP -= damageDealt;
                                            Console.WriteLine(BlankLine);
                                            Console.WriteLine("El cavaller ha atacat al monstre fent-li " + damageDealt + " de dany.");
                                            characterTurnEnded = true;
                                            if (monsterHP < Zero)
                                            {
                                                monsterDead = true;
                                                Console.WriteLine(MonsterDefeated);
                                                break;
                                            }
                                            else
                                                Console.WriteLine("La vida actual del monstre és de " + monsterHP);
                                            break;
                                        case Two:
                                            knightDmgReduction = knightDmgReduction * Two;
                                            knightDefended = true;
                                            Console.WriteLine(DefenseKnight);
                                            characterTurnEnded = true;
                                            if (knightHability > Zero)
                                                Console.WriteLine(KnightDefendWhileabilityActive);
                                            break;
                                        case Three:
                                            if (knightCooldown <= currentTurn || firstHabilityKnight == true)
                                            {

                                                Console.WriteLine(BlankLine);
                                                Console.WriteLine(KnightHability);

                                                knightCooldown = currentTurn + Five;
                                                firstHabilityKnight = false;
                                                characterTurnEnded = true;
                                                knightHability = Three;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine(HabilityOnCooldown);
                                            }
                                            break;

                                        default:
                                            Console.WriteLine(CombatError);
                                            errorsInBattle++;
                                            if (errorsInBattle == Three)
                                                characterTurnEnded = true;
                                            break;
                                    }
                                }
                            }
                            if (errorsInBattle != Three)
                            {
                                characterTurnEnded = false;
                                errorsInBattle = Zero;
                            }


                            if (sorcererDead == false && monsterDead == false && characterTurnEnded == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(SorcererTurn);
                                while (characterTurnEnded == false)
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(Attack);
                                    Console.WriteLine(Defense);
                                    Console.WriteLine(HabilitySorcerer);
                                    currentAction = Convert.ToDecimal(Console.ReadLine());
                                    switch (currentAction)
                                    {
                                        case One:
                                            damageDealt = (sorcererDmg - sorcererDmg * (monsterDmgReduction / OneHundred));
                                            monsterHP -= damageDealt;
                                            Console.WriteLine(BlankLine);
                                            Console.WriteLine("La maga ha atacat al monstre fent-li " + damageDealt + " de dany.");
                                            characterTurnEnded = true;
                                            if (monsterHP < Zero)
                                            {
                                                monsterDead = true;
                                                Console.WriteLine(MonsterDefeated);
                                                break;
                                            }
                                            else
                                                Console.WriteLine("La vida actual del monstre és de " + monsterHP);
                                            break;
                                        case Two:
                                            sorcererDmgReduction = sorcererDmgReduction * Two;
                                            sorcererDefended = true;
                                            Console.WriteLine(DefenseSorcerer);
                                            characterTurnEnded = true;
                                            break;
                                        case Three:
                                            if (sorcererCooldown <= currentTurn || firstHabilitySorcerer == true)
                                            {
                                                damageDealt = ((sorcererDmg - sorcererDmg * (monsterDmgReduction / OneHundred)) * Three);
                                                monsterHP -= damageDealt;
                                                Console.WriteLine(BlankLine);
                                                Console.WriteLine("La maga ha llançat una bola de foc al monstre fent-li " + damageDealt + " de dany.");

                                                sorcererCooldown = currentTurn + Five;
                                                firstHabilitySorcerer = false;
                                                characterTurnEnded = true;
                                                if (monsterHP < Zero)
                                                {
                                                    monsterDead = true;
                                                    Console.WriteLine(MonsterDefeated);
                                                    break;
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine(HabilityOnCooldown);
                                            }
                                            break;
                                        default:
                                            Console.WriteLine(CombatError);
                                            errorsInBattle++;
                                            if (errorsInBattle == Three)
                                                characterTurnEnded = true;
                                            break;

                                    }
                                }
                            }
                            if (errorsInBattle != Three)
                            {
                                characterTurnEnded = false;
                                errorsInBattle = Zero;
                            }


                            if (druidDead == false && monsterDead == false && characterTurnEnded == false)
                            {
                                Console.WriteLine(BlankLine);
                                Console.WriteLine(DruidTurn);
                                while (characterTurnEnded == false)
                                {
                                    Console.WriteLine(BlankLine);
                                    Console.WriteLine(Attack);
                                    Console.WriteLine(Defense);
                                    Console.WriteLine(HabilityDruid);
                                    currentAction = Convert.ToDecimal(Console.ReadLine());
                                    switch (currentAction)
                                    {
                                        case One:
                                            damageDealt = (druidDmg - druidDmg * (monsterDmgReduction / OneHundred));
                                            monsterHP -= damageDealt;
                                            Console.WriteLine(BlankLine);
                                            Console.WriteLine("El druida ha atacat al monstre fent-li " + damageDealt + " de dany.");
                                            characterTurnEnded = true;
                                            if (monsterHP < Zero)
                                            {
                                                monsterDead = true;
                                                Console.WriteLine(MonsterDefeated);
                                                break;
                                            }
                                            else
                                                Console.WriteLine("La vida actual del monstre és de " + monsterHP);
                                            break;
                                        case Two:
                                            druidDmgReduction = druidDmgReduction * Two;
                                            druidDefended = true;
                                            Console.WriteLine(DefenseDruid);
                                            characterTurnEnded = true;
                                            break;
                                        case Three:
                                            if (druidCooldown <= currentTurn || firstHabilityDruid == true)
                                            {
                                                if (archerMaxHP - archerHP <= FiveHundred && archerDead == false)
                                                {
                                                    archerHP = archerMaxHP;
                                                    Console.WriteLine(BlankLine);
                                                    Console.WriteLine("El druida a curat a l'arquera, deixant-la a " + archerHP + " de vida");

                                                }
                                                else if (archerDead == false)
                                                {
                                                    archerHP += FiveHundred;
                                                    Console.WriteLine(BlankLine);
                                                    Console.WriteLine("El druida a curat a l'arquera, deixant-la a " + archerHP + " de vida");
                                                }

                                                if (knightHP - knightHP <= FiveHundred && knightDead == false)
                                                {
                                                    knightHP = knightMaxHP;
                                                    Console.WriteLine(BlankLine);
                                                    Console.WriteLine("El druida a curat al cavaller, deixant-lo a " + knightHP + " de vida");

                                                }
                                                else if (knightDead == false)
                                                {
                                                    knightHP += FiveHundred;
                                                    Console.WriteLine(BlankLine);
                                                    Console.WriteLine("El druida a curat al cavaller, deixant-lo a " + knightHP + " de vida");
                                                }

                                                if (sorcererMaxHP - sorcererHP <= FiveHundred && sorcererDead == false)
                                                {
                                                    sorcererHP = sorcererMaxHP;
                                                    Console.WriteLine(BlankLine);
                                                    Console.WriteLine("El druida a curat a la maga, deixant-la a " + sorcererHP + " de vida");
                                                }
                                                else if (sorcererDead == false)
                                                {
                                                    sorcererHP += FiveHundred;
                                                    Console.WriteLine(BlankLine);
                                                    Console.WriteLine("El druida a curat a la maga, deixant-la a " + sorcererHP + " de vida");
                                                }

                                                if (druidMaxHP - druidHP <= FiveHundred)
                                                {
                                                    druidHP = druidMaxHP;
                                                    Console.WriteLine(BlankLine);
                                                    Console.WriteLine("El druida s'ha curat a si mateix, deixant-se a " + druidHP + " de vida");
                                                }
                                                else
                                                {
                                                    druidHP += FiveHundred;
                                                    Console.WriteLine(BlankLine);
                                                    Console.WriteLine("El druida s'ha curat a si mateix, deixant-se a " + druidHP + " de vida");

                                                }

                                                druidCooldown = currentTurn + Five;
                                                firstHabilityDruid = false;
                                                characterTurnEnded = true;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine(HabilityOnCooldown);
                                            }
                                            break;

                                        default:
                                            Console.WriteLine(CombatError);
                                            errorsInBattle++;
                                            if (errorsInBattle == Three)
                                                characterTurnEnded = true;
                                            break;

                                    }
                                }
                            }
                            Console.WriteLine(BlankLine);
                            if (errorsInBattle != Three)
                            {
                                characterTurnEnded = false;
                                errorsInBattle = Zero;
                            }

                            if (monsterStuned == true)
                            {
                                Console.WriteLine(MonsterStuned);
                                stunDuration--;
                                if (stunDuration == Zero)
                                {
                                    stunDuration = Two;
                                    monsterStuned = false;
                                }
                            }
                            else if (monsterDead == false && characterTurnEnded == false) /*El turn del monstre, en el que el jugador no interacciona*/
                            {
                                if (archerDead == false)
                                {
                                    damageDealt = monsterDmg - monsterDmg * (archerDmgReduction / OneHundred);

                                    Console.WriteLine("El monstre li ha fet " + damageDealt + " de dany a l'arquera.");
                                    archerHP -= damageDealt;
                                    if (archerHP <= Zero)
                                    {
                                        archerDead = true;
                                        Console.WriteLine(ArcherDead);

                                    }
                                    else
                                        Console.WriteLine("Ara l'arquera te " + archerHP + " de vida");

                                }
                                if (knightDead == false)
                                {
                                    if (knightHability > Zero)
                                    {
                                        Console.WriteLine(BlankLine);
                                        Console.WriteLine(KnightHabilityActive);
                                        Console.WriteLine(BlankLine);
                                        knightHability = Zero;
                                    }

                                    else
                                    {
                                        damageDealt = monsterDmg - monsterDmg * (knightDmgReduction / OneHundred);
                                        Console.WriteLine(BlankLine);
                                        Console.WriteLine("El monstre li ha fet " + damageDealt + " de dany al cavaller.");
                                        knightHP -= damageDealt;
                                        if (knightHP <= Zero)
                                        {
                                            knightDead = true;
                                            Console.WriteLine(KnightDead);

                                        }
                                        else
                                            Console.WriteLine("Ara el cavaller te " + knightHP + " de vida");
                                        Console.WriteLine(BlankLine);
                                    }
                                }
                                if (sorcererDead == false)
                                {
                                    damageDealt = monsterDmg - monsterDmg * (sorcererDmgReduction / OneHundred);
                                    Console.WriteLine("El monstre li ha fet " + damageDealt + " de dany a la maga.");
                                    sorcererHP -= damageDealt;
                                    if (sorcererHP <= Zero)
                                    {
                                        sorcererDead = true;
                                        Console.WriteLine(SorcererDead);

                                    }
                                    else
                                        Console.WriteLine("Ara la maga te " + sorcererHP + " de vida");
                                    Console.WriteLine(BlankLine);
                                }
                                if (druidDead == false)
                                {
                                    damageDealt = monsterDmg - monsterDmg * (druidDmgReduction / OneHundred);
                                    Console.WriteLine("El monstre li ha fet " + damageDealt + " de dany al druida.");
                                    druidHP -= damageDealt;
                                    if (druidHP <= Zero)
                                    {
                                        druidDead = true;
                                        Console.WriteLine(DruidDead);

                                    }
                                    else
                                        Console.WriteLine("Ara l'arquera te " + druidHP + " de vida");
                                    Console.WriteLine(BlankLine);
                                }
                            }
                            currentTurn++;
                            if (archerDefended == true) /*Si aquell personatge ha duplicat la seva defensa, es retorna al seu valor original*/
                                archerDmgReduction = archerDmgReduction / Two;
                            if (knightDefended == true)
                                knightDmgReduction = knightDmgReduction / Two;
                            if (sorcererDefended == true)
                                sorcererDmgReduction = sorcererDmgReduction / Two;
                            if (druidDefended == true)
                                druidDmgReduction = druidDmgReduction / Two;


                        }
                    }

                    if (errorsInCharacter == Three || errorsInBattle == Three || monsterDead == true || (archerDead == true && knightDead == true && sorcererDead == true && druidDead == true)) /* Totes les situacions en la que es retorna al menú principal*/
                    {
                        startGame = One;
                        leave = One;
                        Console.WriteLine(BlankLine);
                        Console.WriteLine(BackToMenu);
                        Console.WriteLine(BlankLine);
                    }

                }
            }
        }
    }
}
