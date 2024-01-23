using Constants;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
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
       
        public static bool ErrorTester(double[,] stats ,int i, int j)
        {
            if (Const.EasyStats[i, j] > Const.HardStats[i, j])
            {
                if (stats[i, j] >= Const.HardStats[i, j] && stats[i, j] <= Const.EasyStats[i, j])
                {
                    return false;
                }

                return true;
            }
           else
            {
                if (stats[i, j] <= Const.HardStats[i, j] && stats[i, j] >= Const.EasyStats[i, j])
                {
                    return false;
                }
                return true;
            }
            
        }

        public static bool ErrorTester(int action)
        {
            if (action < 1 || action > 3)
            {
                Console.WriteLine("Tens 3 accions a fer, no es difícil");
                return false;
            }
            return true;
        }
        public static bool CharactersAliveTester(int i, string[] namesArray, double[,] stats)
        {
            switch (i)
            {
                case 0:
                    if (stats[0,i] > 0)
                    {
                        Console.WriteLine($"Es el torn de {namesArray[i]}.");
                        Console.WriteLine(Const.BlankLine);
                        Console.WriteLine(Const.Attack);
                        Console.WriteLine(Const.BlankLine);
                        Console.WriteLine(Const.Defense);
                        Console.WriteLine(Const.BlankLine);
                        Console.WriteLine($"3. {namesArray[i]} stunea al monstre durant 2 torns ");

                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"\n{namesArray[i]} està mort i no pot fer res.\n");
                        return false;
                    }

                case 1:
                    if (stats[0, i] > 0)
                    {
                        Console.WriteLine($"Es el torn de {namesArray[i]}.");
                        Console.WriteLine(Const.BlankLine);
                        Console.WriteLine(Const.Attack);
                        Console.WriteLine(Const.BlankLine);
                        Console.WriteLine(Const.Defense);
                        Console.WriteLine(Const.BlankLine);
                        Console.WriteLine($"3. {namesArray[i]} es torna invulnerable al dany durant 3 torns ");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"\n{namesArray[i]} està mort i no pot fer res.\n");
                        return false;
                    }

                case 2:
                    if (stats[0, i] > 0)
                    {
                        Console.WriteLine($"Es el torn de {namesArray[i]}.");
                        Console.WriteLine(Const.BlankLine);
                        Console.WriteLine(Const.Attack);
                        Console.WriteLine(Const.BlankLine);
                        Console.WriteLine(Const.Defense);
                        Console.WriteLine(Const.BlankLine);
                        Console.WriteLine($"3. {namesArray[i]} llança una bola de foc al monstre que fa el triple de dany que el seu atac normal ({stats[1,3]}).");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"\n{namesArray[i]} està mort i no pot fer res.\n");
                        return false;
                    }
            

                case 3:
                    if (stats[0, i] > 0)
                    {
                        Console.WriteLine($"Es el torn de {namesArray[i]}.");
                        Console.WriteLine(Const.BlankLine);
                        Console.WriteLine(Const.Attack);
                        Console.WriteLine(Const.BlankLine);
                        Console.WriteLine(Const.Defense);
                        Console.WriteLine(Const.BlankLine);
                        Console.WriteLine($"3. {namesArray[i]} retorna 500 de vida als teus aliats. No pot sobrepasar la seva vida màxima ");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"\n{namesArray[i]} està mort i no pot fer res.\n");
                        return false;
                    }
                default: return false;
            }
            
        }
        public static void CombatSelection() 
        {

        }
    }
}
