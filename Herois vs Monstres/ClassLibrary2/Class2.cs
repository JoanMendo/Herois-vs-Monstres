using Constants;
using System.Reflection.Metadata.Ecma335;
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
        public static int ErrorTester(string[] names)
        {
            
            if (names.Length != Const.Five)
            {
                Console.WriteLine(Const.BlankLine);
                Console.Write(Const.IntroduceNamesError.Substring(0, 16));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(Const.IntroduceNamesError.Substring(16, 4));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Const.IntroduceNamesError.Substring(20, 81));
                Console.WriteLine(Const.BlankLine);
                return Const.One;
            }
            return Const.Zero;
        }
        public static void ErrorTester(int errors)
        {
            if (errors == Const.Three)
            {
                Console.WriteLine(Const.MenuErrorLeave);

            }

        }
        public static int ErrorTester(double[,] stats ,int i, int j)
        {
            if (Const.EasyStats[i, j] > Const.HardStats[i, j])
            {
                if (stats[i, j] > Const.HardStats[i, j] && stats[i, j] < Const.EasyStats[i, j])
                {
                    return 0;
                }
                Console.WriteLine(Const.BlankLine);
                Console.WriteLine(Const.ErrorInValue);
                Console.WriteLine(Const.BlankLine);
                return 1;
            }
           else
            {
                if (stats[i, j] < Const.HardStats[i, j] && stats[i, j] > Const.EasyStats[i, j])
                {
                    return 0;
                }
                Console.WriteLine(Const.BlankLine);
                Console.WriteLine(Const.ErrorInValue);
                Console.WriteLine(Const.BlankLine);
                return 1;
            }
            
        }
        
    }
}
