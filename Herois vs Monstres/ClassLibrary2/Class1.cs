using Constants;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Metodos
{
    public class Class2
    {
        public static int StartingMenu (int startGame)
        {
            
            if (startGame == Nums.Zero)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Text.BlankLine);
                Console.WriteLine(Text.LeaveConfirmed);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Text.BlankLine);
                return Nums.Zero;
            }
            else if (startGame == Nums.One)
            {
                Console.WriteLine(Text.BlankLine);
                return Nums.One;
            }
            else
            {
                Console.WriteLine(Text.BlankLine);
                Console.WriteLine(Text.StartError);
                Console.WriteLine(Text.BlankLine);
                return Nums.Two;
            }
        }
        public static int CharacterNamesCheck(string[] names)
        {
            
            if (names.Length != Nums.Four)
            {
                Console.WriteLine(Text.BlankLine);
                Console.Write(Text.IntroduceNamesError.Substring(0, 16));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(Text.IntroduceNamesError.Substring(16, 6));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Text.IntroduceNamesError.Substring(22, 68));
                Console.WriteLine(Text.BlankLine);
                return Nums.One;
            }
            return Nums.Zero;
        }
        public static void TotalErrorsAchievedMessage(int errors)
        {
            if (errors == Nums.Three)
            {
                Console.WriteLine(Text.MenuErrorLeave);

            }

        }
        
        public static double[] MaxHp(int selection)
        {
            switch (selection)
            {
                case 1:
                    double[] EasyHP = {Nums.TwoThousand,Nums.ThreeThousandSevenHundredSeventyFive, Nums.OneThousandFiveHundred, Nums.TwoThousandAndFiveHundred, Nums.SevenThousand};
                    return EasyHP;
                case 2:
                    double[] HardHP = {Nums.OneHundredAndFifty, Nums.ThreeThousand, Nums.OneThousandOneHundred, Nums.TwoThousand, Nums.TenThousand};
                    return HardHP;
                case 3:
                    return Nums.Three;
                case 4:
                    return Nums.Four;
                default:
                    Console.WriteLine(Text.DificultyError);
                    return Nums.Four;
            }
        }

        public static int[] DamageReduction(int selection)
        {
            switch (selection)
            {
                case 1:
                    int[] EasyDMG = {Nums.ThreeHundred, Nums.TwoHundredAndFifty, Nums.FourHundred, Nums.OneHundredAndTwenty, Nums.ThreeHundred};
                    return EasyDMG;
                case 2:
                    int[] HardDMG = {Nums.TwoHundred, Nums.OneHundredAndFifty, Nums.ThreeHundred, Nums.Seventy, Nums.FourHundred};
                    return HardDMG;
                case 3:
                    return Nums.Three;
                case 4:
                    return Nums.Four;
                default:
                    Console.WriteLine(Text.DificultyError);
                    return Nums.Four;
            }
        }

        public static int[] AttackDamage(int selection)
        {
            switch (selection)
            {
                case 1:
                    int[] EasyDMGReduction = {Nums.ThirtyFive, Nums.FortyFive, Nums.ThirtyFive, Nums.Forty, Nums.Twenty};
                    return EasyDMGReduction;
                case 2:
                    int[] HardDMGReduction = {Nums.TwentyFive, Nums.ThirtyFive, Nums.Twenty, Nums.TwentyFive, Nums.Thirty};
                    return HardDMGReduction;
                case 3:
                    return Nums.Three;
                case 4:
                    return Nums.Four;
                default:
                    Console.WriteLine(Text.DificultyError);
                    return Nums.Four;
            }
        }
    }
}
