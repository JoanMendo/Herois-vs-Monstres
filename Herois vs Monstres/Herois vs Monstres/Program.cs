using System;
using System.Threading;
using Constants;
using Metodos;

namespace PR1
{
    public class si
    {
        public static void Main()
        {

            decimal menuErrors = Class1.Zero;
            decimal totalErrors = Class1.Zero;
            decimal startGame = Class1.One;
            decimal leave = Class1.One;
            decimal errorsInStat = Class1.Zero;
            decimal errorsInCharacter = Class1.Zero;
            decimal archerHP = Class1.Zero, knightHP = Class1.Zero, sorcererHP = Class1.Zero, druidHP = Class1.Zero, monsterHP = Class1.Zero;
            decimal archerMaxHP = Class1.Zero, knightMaxHP = Class1.Zero, sorcererMaxHP = Class1.Zero, druidMaxHP = Class1.Zero;
            decimal archerDmg = Class1.Zero, knightDmg = Class1.Zero, sorcererDmg = Class1.Zero, druidDmg = Class1.Zero, monsterDmg = Class1.Zero;
            decimal archerDmgReduction = Class1.Zero, knightDmgReduction = Class1.Zero, sorcererDmgReduction = Class1.Zero, druidDmgReduction = Class1.Zero, monsterDmgReduction = Class1.Zero;


            decimal errorsInBattle = Class1.Zero;
            bool archerDead = false, knightDead = false, sorcererDead = false, druidDead = false, monsterDead = false;
            bool archerDefended = false, knightDefended = false, sorcererDefended = false, druidDefended = false;
            decimal archerCooldown = Class1.Zero, knightCooldown = Class1.Zero, sorcererCooldown = Class1.Zero, druidCooldown = Class1.Zero;
            bool firstHabilityArcher = true, firstHabilityKnight = true, firstHabilitySorcerer = true, firstHabilityDruid = true;
            decimal currentTurn = Class1.One;
            decimal currentAction = Class1.Zero;
            decimal damageDealt = Class1.Zero;
            bool characterTurnEnded = false;
            bool monsterStuned = false;
            decimal stunDuration = Class1.Two;
            decimal knightHability = Class1.Three;

            bool repeatStats = false;
            bool archerCreationCorrect = false, knightCreationCorrect = false, sorcererCreationCorrect = false, druidCreationCorrect = false, monsterCreationCorrect = false;

            Console.WriteLine(Class1.StartingMsg);

            while (startGame == Class1.One && leave == Class1.One) /* Bucle per a que el programa se repeteixi */
            {
                errorsInCharacter = Class1.Zero;
                errorsInBattle = Class1.Zero;
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
                currentTurn = Class1.One;
                monsterStuned = false;
                stunDuration = Class1.Two;

                Console.WriteLine(Class1.StartLeave); /*Missatge inicial*/

                while (menuErrors < Class1.Three)  /*Bucle per a poder fer 3 errors al menú*/
                {
                    Console.WriteLine(Class1.HowToLeave);
                    Console.WriteLine(Class1.HowToPlay);
                    startGame = Convert.ToDecimal(Console.ReadLine());
                    leave = Class1.Zero;

                    if (Class2.startingMenu(leave)= Class1.Two)
                    {
                        menuErrors++;
                    }
                    if (startGame == Class1.Zero)
                    {
                        Console.WriteLine(BlankLine);
                        Console.WriteLine(Leave);  /*Missatge per a confirmar la sortida del programa*/
                        leave = Convert.ToDecimal(Console.ReadLine());
                        if (leave == Class1.Zero)
                        {
                            Console.WriteLine(LeaveConfirmed);
                            menuErrors = Three;
                            totalErrors = Three;
                        }
                        else
                            startGame = One;
                    }
                    if ((startGame != One && startGame != Class1.Zero) || (leave != One && leave != Class1.Zero)) /*Codi en cas d'error al menú*/
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
                    menuErrors = Class1.Zero;
                    totalErrors = Class1.Zero;
                    Console.WriteLine(BlankLine);
                    Console.WriteLine(StartToCreate);

                    while (errorsInCharacter < Three) /*Bucle per a la creacio de personatges*/
                    {
                        errorsInStat = Class1.Zero;
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
                            errorsInStat = Class1.Zero;
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
                            errorsInStat = Class1.Zero;
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
                            errorsInStat = Class1.Zero;
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
                            errorsInStat = Class1.Zero;
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
                            errorsInStat = Class1.Zero;
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
                            errorsInStat = Class1.Zero;
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
                            errorsInStat = Class1.Zero;
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
                            errorsInStat = Class1.Zero;
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
                            errorsInStat = Class1.Zero;
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
                            errorsInStat = Class1.Zero;
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
                            errorsInStat = Class1.Zero;
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
                            errorsInStat = Class1.Zero;
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
                            errorsInStat = Class1.Zero;
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
                            errorsInStat = Class1.Zero;
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
                            errorsInStat = Class1.Zero;
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
                                errorsInBattle = Class1.Zero;
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
                                            if (monsterHP < Class1.Zero)
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
                                errorsInBattle = Class1.Zero;
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
                                            if (monsterHP < Class1.Zero)
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
                                            if (knightHability > Class1.Zero)
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
                                errorsInBattle = Class1.Zero;
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
                                            if (monsterHP < Class1.Zero)
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
                                                if (monsterHP < Class1.Zero)
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
                                errorsInBattle = Class1.Zero;
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
                                            if (monsterHP < Class1.Zero)
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
                                errorsInBattle = Class1.Zero;
                            }

                            if (monsterStuned == true)
                            {
                                Console.WriteLine(MonsterStuned);
                                stunDuration--;
                                if (stunDuration == Class1.Zero)
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
                                    if (archerHP <= Class1.Zero)
                                    {
                                        archerDead = true;
                                        Console.WriteLine(ArcherDead);

                                    }
                                    else
                                        Console.WriteLine("Ara l'arquera te " + archerHP + " de vida");

                                }
                                if (knightDead == false)
                                {
                                    if (knightHability > Class1.Class1.Zero)
                                    {
                                        Console.WriteLine(BlankLine);
                                        Console.WriteLine(KnightHabilityActive);
                                        Console.WriteLine(BlankLine);
                                        knightHability = Class1.Zero;
                                    }

                                    else
                                    {
                                        damageDealt = monsterDmg - monsterDmg * (knightDmgReduction / OneHundred);
                                        Console.WriteLine(BlankLine);
                                        Console.WriteLine("El monstre li ha fet " + damageDealt + " de dany al cavaller.");
                                        knightHP -= damageDealt;
                                        if (knightHP <= Class1.Zero)
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
                                    if (sorcererHP <= Class1.Zero)
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
                                    if (druidHP <= Class1.Zero)
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
