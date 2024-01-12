using Constants;

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
    }
}
