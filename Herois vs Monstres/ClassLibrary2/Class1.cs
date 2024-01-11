using Constants;

namespace Metodos
{
    public class Class2
    {
        public static int StartingMenu (decimal startGame)
        {
            decimal leave = Class1.Zero;
            if (startGame == 0)
            {
                Console.WriteLine(Class1.BlankLine);
                Console.WriteLine(Class1.Leave);  /*Missatge per a confirmar la sortida del programa*/
                Console.WriteLine(Class1.BlankLine);
                leave = Convert.ToDecimal(Console.ReadLine());
                return leaveGame(leave);
            }
            else if (startGame == 1)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(Class1.StartError);
                return 2;
            }
        }
        public static int leaveGame (decimal leave)
        {
            if (leave == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Class1.BlankLine);
                Console.WriteLine(Class1.LeaveConfirmed);
                Console.ForegroundColor = ConsoleColor.White;
                return 0;
            }
            else if (leave == 1)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(Class1.StartError);
                return 2;
            }
        }
    }
}
