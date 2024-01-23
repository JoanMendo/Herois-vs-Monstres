namespace Constants
{
    public class Const
    {
        /*Definició de constants i variables*/
        public static readonly string[] StartingMessages = { StartingMsg, StartLeave, HowToPlay, HowToLeave };
        public static readonly string[] Stats = { "la vida", "l'atac", "la reduccio d'atac" };
        public const string StartingMsg = "Benvingut a Herois vs Monstres!";
        public const string StartLeave = "Que vols fer ?";
        public const string HowToPlay = "1. Jugar a aquesta obra maestra del gaming";
        public const string HowToLeave = "0. Tancar el programa";

        public const string StartError = "Tens que escriure 0 per sortir del programa, o 1 per jugar, no és tan dificil.";
        public const string MenuErrorLeave = "Bueno, si no etc capaç ni de començar a jugar, no continuis.";
        public const string LeaveConfirmed = "Bueno, donç moltes gràcies per apofitar d'aquesta manera les hores que he invertit creant això. Que tinguis un mal dia.";
        public const string MenuReturn = "Tornem al menú principal";

        public static readonly string[] DificultyMessages = { Dificulty, Easy, Medium, Hard, Custom };
        public const string Dificulty = "Selecciona la dificultat del joc";
        public const string Easy = "1. Fàcil";
        public const string Medium = "2. Difìcil";
        public const string Hard = "3. Random";
        public const string Custom = "4. Customitzat";
        public const string DificultyError = "Mira que bé, no saps ni posar un nombre de l'1 al 4,";

        public const string IntroduceNames = "Introdueix els noms dels 5 personatges (l´arquera, el bàrbar, la maga, el druida, i del monstre)  separats per comes. ";
        public const string IntroduceNamesError = "Has d'introduir CINC noms separats per comes, l'arquera, el bàrbar, la maga, el druida, i el monstre.";
        public const string ErrorInValue = "Has d'introduir un nombre que estigui dins de l'interval especificat.";
        public const string RandomValueInsertion = "Veig que et costa, passem al següent atribut";

        public const string ActionError = "Tens 3 accions a fer, no es difícil";
        public static string NoTurn = "Et quedas sense torn per inútil.";
        public static string FailedAttack = "El teu personatge és inutil i ha fallat l'atac";

        public const string BattleStart = "Comença la batalla conta el monstre. Recorda que les habilitats dels personatges tenen un cooldown de 5 torns, i que fer 3 errors al seleccionar l'acció d'un personatge saltarà el seu torn. ";
        public const string Attack = "1. Atacar al monstre";
        public const string Defense = "2. Defensarse (Duplica la reducció de dany aquest torn)";
        public const string CombatError = "1 per atacar, 2 per defensar-se, 3 per l'abilitat, no és tan difícil.";
        public const string MonsterDefeated = "Felicitats, has acabat amb el monstre";
        public const string HeroesDefeated = "Tots els teus herois han mort, ets dolentisim";
        public const string ArcherStun = "L'arquera a stunejat al monstre durant 2 turns";
        public const string HabilityOnCooldown = "Aquesta habilitat està en cooldown";
        public static string MonsterAttacks = "El monstre acaba d'atacar";
        public const string MonsterStuned = "El monstre està stuneat i no atacarà aquest torn";
        public const string KnightHability = "El cavaller es protegeix, i serà invulnerable al dany durant tres torns";
        public const string KnightInvulnerable = "El cavaller no ha patit ningun mal aquest torn";
        public const string BlankLine = " ";

        public const int Zero = 0;
        public const int One = 1;
        public const int Two = 2;
        public const int Three = 3;
        public const int Four = 4;
        public const int Five = 5;
        public const int Twenty = 20;
        public const int OneHundred = 100;
        public const int FiveHundred = 500;

        public static readonly double[,] EasyStats = { { 2000, 3750, 1500, 2500, 7000 }, { 300, 250, 400, 120, 300 }, { 35, 45, 35, 40, 20 } };
        public static readonly double[,] HardStats = { { 1500, 3000, 1100, 2000, 10000 }, { 200, 150, 300, 70, 400 }, { 25, 35, 20, 25, 30 } };
    }
}
