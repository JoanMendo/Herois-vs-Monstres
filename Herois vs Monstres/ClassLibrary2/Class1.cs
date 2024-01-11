using Constants;

namespace Metodos
{
    public class Class2
    {
        public static decimal startingMenu (decimal startGame)
        {
            decimal leave = Class1.Zero;
            if (startGame == 0)
            {
                Console.WriteLine(Class1.BlankLine);
                Console.WriteLine(Class1.Leave);  /*Missatge per a confirmar la sortida del programa*/
                leave = Convert.ToDecimal(Console.ReadLine());
                return leaveGame(leave);
            }
            else if (startGame == 1)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public static decimal leaveGame (decimal leave)
        {
            if (leave == 0)
            {
                Console.WriteLine(Class1.LeaveConfirmed);
                return 0;
            }
            else if (leave == 1)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
