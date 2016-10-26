using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Pwd
    {

        public static void pwd(int x)
        {
            switch (x)
            {
                case 0:
                    Console.WriteLine("/home");
                    break;

                case 1:
                    Console.WriteLine("/home/desktop");
                    break;

                case 2:
                    Console.WriteLine("/home/documents");
                    break;

                case 3:
                    Console.WriteLine("/home/downloads");
                    break;

                case 4:
                    Console.WriteLine("/home/other");
                    break;

                default:
                    break;
            }
        }

        public static string pw(int x)
        {

            string saida = "";

            switch (x)
            {
                case 0:
                    break;

                case 1:
                    saida = "/desktop";
                    break;

                case 2:
                    saida = "/documents";
                    break;

                case 3:
                    saida = "/downloads";
                    break;

                case 4:
                    saida = "/other";
                    break;

                default:
                    break;
            }

            return saida;

        }

        public static void no(string c)
        {
            Console.WriteLine("-bash: {0}: no such file or directory", c);
        }

    }
}