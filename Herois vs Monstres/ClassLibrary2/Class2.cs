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
