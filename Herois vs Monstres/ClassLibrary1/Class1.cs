namespace Constants
{
    public class Class1
    {
        /* Definició de constants i variables*/
        public const string StartingMsg = "Benvingut a Herois vs Monstres!";
        public const string StartLeave = "Que vols fer ?";
        public const string HowToPlay = "1. Jugar a aquesta obra maestra del gaming";
        public const string HowToLeave = "0. Tancar el programa";
        public const string StartError = "Tens que escriure 0 per sortir del programa, o 1 per jugar, no és tan dificil.";
        public const string MenuErrorLeave = "Bueno, si no etc capaç ni de començar a jugar, no continuis.";
        public const string Leave = "Estas segur de que vols marchar? Aquest joc es molt divertit, prem 0 només si estas segur de que no vols jugar. Va, prem 1.";
        public const string LeaveConfirmed = "Bueno, donç moltes gràcies per apofitar d'aquesta manera les hores que he invertit creant això. Que tinguis un mal dia.";
        public const string BackToMenu = "Total d'errors assolits, retornant al menú";

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

        public const decimal Zero = 0;
        public const decimal One = 1;
        public const decimal Two = 2;
        public const decimal Three = 3;
        public const decimal Five = 5;
        public const decimal Twenty = 20;
        public const decimal Thirty = 30;
        public const decimal Seventy = 70;
        public const decimal OneHundred = 100;
        public const decimal OneHundredAndTwenty = 120;
        public const decimal FiveHundred = 500;
        public const decimal OneThousandFiveHundred = 1500;
        public const decimal TwoThousand = 2000;
        public const decimal TwoThousandAndFiveHundred = 2500;
        public const decimal OneHundredAndEighty = 180;
        public const decimal ThreeHundred = 300;
        public const decimal TwentyFive = 25;
        public const decimal Forty = 40;
        public const decimal ThreeThousand = 3000;
        public const decimal ThreeThousandSevenHundredSeventyFive = 3750;
        public const decimal OneHundredAndFifty = 150;
        public const decimal TwoHundredAndFifty = 250;
        public const decimal FourHundred = 400;
        public const decimal ThirtyFive = 35;
        public const decimal FortyFive = 45;
        public const decimal OneThousand = 1000;
        public const decimal ThreeHundredAndFifty = 350;
        public const decimal NineThousand = 9000;
        public const decimal TwelveThousand = 12000;
    }
}
