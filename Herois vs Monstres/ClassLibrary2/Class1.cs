using Constants;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Metodos
{
    public class Class2
    {
        public static int StartingMenu (int startGame)
        {
            
            if (startGame == Const.Zero)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Const.BlankLine);
                Console.WriteLine(Const.LeaveConfirmed);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Const.BlankLine);
                return Const.Zero;
            }
            else if (startGame == Const.One)
            {
                Console.WriteLine(Const.BlankLine);
                return Const.One;
            }
            else
            {
                Console.WriteLine(Const.BlankLine);
                Console.WriteLine(Const.StartError);
                Console.WriteLine(Const.BlankLine);
                return Const.Two;
            }
        }
        public static int CharacterNamesCheck(string[] names)
        {
            
            if (names.Length != Const.Four)
            {
                Console.WriteLine(Const.BlankLine);
                Console.Write(Const.IntroduceNamesError.Substring(0, 16));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(Const.IntroduceNamesError.Substring(16, 6));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Const.IntroduceNamesError.Substring(22, 68));
                Console.WriteLine(Const.BlankLine);
                return Const.One;
            }
            return Const.Zero;
        }
        public static void TotalErrorsAchievedMessage(int errors)
        {
            if (errors == Const.Three)
            {
                Console.WriteLine(Const.MenuErrorLeave);

            }

        }
        
        public static double[] MaxHp(int selection)
        {
            switch (selection)
            {
                case Const.One:
                    double[] EasyHP = {Const.TwoThousand,Const.ThreeThousandSevenHundredSeventyFive, Const.OneThousandFiveHundred, Const.TwoThousandAndFiveHundred, Const.SevenThousand};
                    return EasyHP;
                case Const.Two:
                    double[] HardHP = {Const.OneHundredAndFifty, Const.ThreeThousand, Const.OneThousandOneHundred, Const.TwoThousand, Const.TenThousand};
                    return HardHP;
                case Const.Three:
                    Random RandomNum = new Random();
                    double[] RandomHP = { RandomNum.Next(Const.OneHundredAndFifty, Const.TwoThousand), RandomNum.Next(Const.ThreeThousand, Const.ThreeThousandSevenHundredSeventyFive),
                                          RandomNum.Next(Const.OneThousandOneHundred, Const.OneThousandFiveHundred), 
                                          RandomNum.Next(Const.TwoThousand, Const.TwoThousandAndFiveHundred), RandomNum.Next(Const.SevenThousand, Const.TenThousand)};
                    return RandomHP;
                case Const.Four:
                    double[] ManualHP = new double[5];
                    return ManualHP;
                default:
                    Console.WriteLine(Const.DificultyError);
                    double[] error = new double[5];
                    return error;
            }
        }

        public static int[] DamageReduction(int selection)
        {
            switch (selection)
            {
                case Const.One:
                    int[] EasyDMG = {Const.ThreeHundred, Const.TwoHundredAndFifty, Const.FourHundred, Const.OneHundredAndTwenty, Const.ThreeHundred};
                    return EasyDMG;
                case Const.Two:
                    int[] HardDMG = {Const.TwoHundred, Const.OneHundredAndFifty, Const.ThreeHundred, Const.Seventy, Const.FourHundred};
                    return HardDMG;
                case Const.Three:
                    Random RandomNum = new Random();
                    int[] RandomDMG = { RandomNum.Next(Const.TwoHundred, Const.ThreeHundred), RandomNum.Next(Const.OneHundredAndFifty, Const.TwoHundredAndFifty), 
                                        RandomNum.Next(Const.ThreeHundred, Const.FourHundred), RandomNum.Next(Const.Seventy, Const.OneHundredAndTwenty), 
                                        RandomNum.Next(Const.ThreeHundred, Const.FourHundred) };
                    return RandomDMG;
                case Const.Four:
                    int[] ManualDMG = new int[5];
                    return ManualDMG;
                default:
                    Console.WriteLine(Const.DificultyError);
                    int[] error = new int[5];
                    return error;
            }
        }

        public static int[] AttackDamage(int selection)
        {
            switch (selection)
            {
                case Const.One:
                    int[] EasyDMGReduction = {Const.ThirtyFive, Const.FortyFive, Const.ThirtyFive, Const.Forty, Const.Twenty};
                    return EasyDMGReduction;
                case Const.Two:
                    int[] HardDMGReduction = {Const.TwentyFive, Const.ThirtyFive, Const.Twenty, Const.TwentyFive, Const.Thirty};
                    return HardDMGReduction;
                case Const.Three:
                    Random RandomNum = new Random();
                    int[] RandomDMGReduction = { RandomNum.Next(Const.TwentyFive, Const.ThirtyFive), RandomNum.Next(Const.ThirtyFive, Const.FortyFive),
                                        RandomNum.Next(Const.Twenty,Const.ThirtyFive), RandomNum.Next(Const.TwentyFive, Const.Forty),
                                        RandomNum.Next(Const.Twenty, Const.Thirty) };
                    return RandomDMGReduction;
                case Const.Four:
                    int[] ManualDMGReduction = new int[5];
                    return ManualDMGReduction;
                default:
                    Console.WriteLine(Const.DificultyError);
                    int[] error = new int[5];
                    return error;
            }
        }

        public static int CharactersStatsCheck(int selection)
        {
            if (selection < 1 || selection > 4)
            {
                Console.WriteLine(Const.BlankLine);
                Console.WriteLine(Const.DificultyError);
                Console.WriteLine(Const.BlankLine);
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
