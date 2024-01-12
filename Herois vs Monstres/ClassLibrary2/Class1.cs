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
                Console.WriteLine(Text.BlankLine);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Text.BlankLine);
                Console.WriteLine(Text.LeaveConfirmed);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Text.BlankLine);
                return Nums.Zero;
            }
            else if (startGame == Nums.One)
            {
                return Nums.One;
            }
            else
            {
                Console.WriteLine(Text.StartError);
                return Nums.Two;
            }
        }
        public static int CharacterNamesCheck(string[] names)
        {
            
            if (names.Length != Nums.Four)
            {

                Console.Write(Text.IntroduceNamesError.Substring(0, 16));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(Text.IntroduceNamesError.Substring(16, 6));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Text.IntroduceNamesError.Substring(22, 68));
                return Nums.One;
            }
            return Nums.Zero;
        }
        public static bool TotalErrorsAchieved(int errors)
        {
            if (errors == Nums.Three)
            {
                Console.WriteLine(Text.MenuErrorLeave);
                return true;
            }
            return false;
        }
        public static int DifficultyCheck(int difficulty)
        {
            if (difficulty > 0 && difficulty < 5)
            {
                return Nums.Zero;
            }
            else
            {
                Console.WriteLine(Text.DificultyError);
                return Nums.One;
            }
        }
    }
}
