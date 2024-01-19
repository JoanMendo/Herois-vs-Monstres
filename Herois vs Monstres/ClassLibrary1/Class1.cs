﻿namespace Constants
{
    public class Const
    {
        /* Definició de constants i variables*/
        public static readonly string[] StartingMessages = { StartingMsg, StartLeave, HowToPlay, HowToLeave };
        public static readonly string[] Stats = { "la vida", "l'atac", "la reduccio d'atac" };
        public const string StartingMsg = "Benvingut a Herois vs Monstres!";
        public const string StartLeave = "Que vols fer ?";
        public const string HowToPlay = "1. Jugar a aquesta obra maestra del gaming";
        public const string HowToLeave = "0. Tancar el programa";

        public const string StartError = "Tens que escriure 0 per sortir del programa, o 1 per jugar, no és tan dificil.";
        public const string MenuErrorLeave = "Bueno, si no etc capaç ni de començar a jugar, no continuis.";
        public const string LeaveConfirmed = "Bueno, donç moltes gràcies per apofitar d'aquesta manera les hores que he invertit creant això. Que tinguis un mal dia.";

        public static readonly string[] DificultyMessages = { Dificulty, Easy, Medium, Hard, Custom };
        public const string Dificulty = "Selecciona la dificultat del joc";
        public const string Easy = "1. Fàcil";
        public const string Medium = "2. Difìcil";
        public const string Hard = "3. Random";
        public const string Custom = "4. Customitzat";
        public const string DificultyError = "Mira que bé, no saps ni posar un nombre de l'1 al 4,";

        public const string IntroduceNames = "Introdueix els noms dels 4 personatges i del monstre separats per comes, l´arquera, el bàrbar, la maga, el druida, i el monstre. ";
        public const string IntroduceNamesError = "Has d'introduir CINC noms separats per comes, l'arquera, el bàrbar, la maga, el druida, i el monstre.";
        public const string StartToCreate = "Primer toca definir las estadístiques dels personatges, dins del rang que s'especificarà dins de [] Si et surts del limit 3 cops, tornaras a l'inici de crear el personatge. Si això passa 3 cops, tornaras al menú.";
        public const string StartArcher = "El primer personatge és l'arquera.";
        public const string StartKnight = "El segon personatge és el cavaller.";
        public const string StartSorcerer = "El tercer personatge és la maga.";
        public const string StartDruid = "El quart personatge és el druida.";
        public const string StartMonster = "Finalment, el monstre.";
        public const string ErrorInValue = "Has d'introduir un nombre que estigui dins de l'interval especificat.";
        public const string RetryValueInsertion = "Torna a introduir les dades d'aquest personatge.";

        public const string ArcherHP = "Introdueix la vida que tindrà l'arquera [1500-2000]";
        public const string KnightHP = "Introdueix la vida que tindrà el cavaller [3000-3750]";
        public const string SorcererHP = "Introdueix la vida que tindrà la maga [1000-1500]";
        public const string DruidHP = "Introdueix la vida que tindrà el druida [2000-2500]";
        public const string MonsterHP = "Introdueix la vida que tindrà el monstre [9000-12000]";

        public const string ArcherDmg = "Introdueix l'atac que tindrà l'arquera [180-300]";
        public const string KnightDmg = "Introdueix l'atac  que tindrà el cavaller [150-250]";
        public const string SorcererDmg = "Introdueix l'atac que tindrà la maga [300-350]";
        public const string DruidDmg = "Introdueix l'atac que tindrà el druida [70-120]";
        public const string MonsterDmg = "Introdueix l'atac que tindrà el monstre [250-400]";

        public const string ArcherDmgReduction = "Introdueix la reducció de dany que tindrà l'arquera [25-40]%";
        public const string KnightDmgReduction = "Introdueix la reducció de dany que tindrà el cavaller [35-45]%";
        public const string SorcererDmgReduction = "Introdueix la reducció de dany que tindrà la maga [20-35]%";
        public const string DruidDmgReduction = "Introdueix la reducció de dany que tindrà el druida [25-40]%";
        public const string MonsterDmgReduction = "Introdueix la reducció de dany que tindrà el monstre [20-30]%";

        public const string BattleStart = "Comença la batalla conta el monstre. Recorda que les habilitats dels personatges tenen un cooldown de 5 torns, i que fer 3 errors al seleccionar l'ació d'un personatge et retornarà al menú. ";
        public const string ArcherTurn = "És el torn de l'arquera";
        public const string KnightTurn = "És el torn del cavaller";
        public const string SorcererTurn = "És el torn de la maga";
        public const string DruidTurn = "És el torn del druida";
        public const string Attack = "1. Atacar al monstre";
        public const string Defense = "2. Defensarse (Duplica la reducció de dany aquest torn)";
        public const string DefenseArcher = "L'arquera es defensarà aquest torn.";
        public const string DefenseKnight = "El cavaller es defensarà aquest torn";
        public const string DefenseSorcerer = "La maga es defensarà aquesta ronda";
        public const string DefenseDruid = "El druida es defensarà aquesta ronda";
        public const string HabilityArcher = "3. Stunea al monstre durant 2 torns";
        public const string HabilityKnight = "3. El cavaller es torna invulnerable al dany durant 3 torns";
        public const string HabilitySorcerer = "3. Lança una bola de foc al monstre que fa el triple de dany que l'atac normal de la maga";
        public const string HabilityDruid = "3. Retorna 500 de vida als teus aliats. No pot sobrepasar la seva vida màxima";
        public const string CombatError = "1 per atacar, 2 per defensar-se, 3 per l'abilitat, no és tan difícil.";
        public const string MonsterDefeated = "Felicitats, has acabat amb el monstre";
        public const string ArcherDead = "La arquera s'acaba de morir";
        public const string KnightDead = "El cavaller s'acaba de morir";
        public const string SorcererDead = "La maga s'acaba de morir";
        public const string DruidDead = "El druida s'acaba de morir";
        public const string ArcherStun = "L'arquera a stunejat al monstre durant 2 turns";
        public const string HabilityOnCooldown = "Aquesta habilitat està en cooldown";
        public const string MonsterStuned = "El monstre està stunejat i no atacarà aquest torn";
        public const string KnightHability = "El cavaller  es protegeix, i serà invulnerabble al dany durant tres torns";
        public const string KnightHabilityActive = "El monstre ataca al cavaller, pero al cavaller se la pela tot";
        public const string KnightDefendWhileabilityActive = "Això no ha servit de res perquè igualment no habria rebut dany, però no et desanimis campió";

        public const string BlankLine = " ";

        public const int Zero = 0;
        public const int One = 1;
        public const int Two = 2;
        public const int Three = 3;
        public const int Four = 4;
        public const int Five = 5;
        public const int Twenty = 20;
        public const int TwentyFive = 25;
        public const int Thirty = 30;
        public const int ThirtyFive = 35;
        public const int Forty = 40;
        public const int FortyFive = 45;
        public const int Seventy = 70;
        public const int OneHundred = 100;
        public const int OneHundredAndTwenty = 120;
        public const int OneHundredAndFifty = 150;
        public const int OneHundredAndEighty = 180;
        public const int TwoHundred = 200;
        public const int TwoHundredAndFifty = 250;
        public const int ThreeHundred = 300;
        public const int ThreeHundredAndFifty = 350;
        public const int FourHundred = 400;
        public const int FiveHundred = 500;
        public const int OneThousand = 1000;
        public const int OneThousandOneHundred = 1100;
        public const int OneThousandFiveHundred = 1500;
        public const int TwoThousand = 2000;
        public const int TwoThousandAndFiveHundred = 2500;
        public const int ThreeThousand = 3000;
        public const int ThreeThousandSevenHundredFifty = 3750;
        public const int SevenThousand = 7000;
        public const int TenThousand = 10000;
        public static readonly double[,] EasyStats = { { 2000, 3750, 1500, 2500, 7000 }, { 300, 250, 400, 120, 300 }, { 35, 45, 35, 40, 20 } };
        public static readonly double[,] HardStats = { { 1500, 3000, 1100, 2000, 10000 }, { 200, 150, 300, 70, 400 }, { 25, 35, 20, 25, 30 } };
    }
}
