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
        
        public static int MaxHp(int selection)
        {
            switch (selection)
            {
                case 1:
                    return Nums.One;
                case 2:
                    return Nums.Two;
                case 3:
                    return Nums.Three;
                case 4:
                    return Nums.Four;
                default:
                    Console.WriteLine(Text.DificultyError);
                    return Nums.Four;
            }
        }

        public static int DamageReduction(int selection)
        {
            switch (selection)
            {
                case 1:
                    return Nums.One;
                case 2:
                    return Nums.Two;
                case 3:
                    return Nums.Three;
                case 4:
                    return Nums.Four;
                default:
                    Console.WriteLine(Text.DificultyError);
                    return Nums.Four;
            }
        }

        public static int AttackDamage(int selection)
        {
            switch (selection)
            {
                case 1:
                    return Nums.One;
                case 2:
                    return Nums.Two;
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
