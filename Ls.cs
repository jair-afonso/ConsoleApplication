using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Ls
    {
        public static void ls(int x)
        {
            switch (x)
            {
               case 0:
                    Console.WriteLine("desktop   documents   downloads   other\nnota.txt");
                    break;

                case 1:
                    break;

                case 2:
                    Console.WriteLine("ftp.txt   nota2.txt");
                    break;

                case 3:
                    
                    if (Meter.aquisitores)
                    {
                        Console.WriteLine("msfconsole   aquisitores.pdf");
                    }
                    else
                    {
                        if (Ftp.download)
                        {
                            Console.WriteLine("msfconsole");
                        }
                    }
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("et");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;

                default:
                    break;
            }
        }
    }
}