using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string comando;

            int x = 0;
            int[] caminho;
            caminho = new int[5];
            for (int x0 = 0; x0 < 5; x0++)
            {
                caminho[x0] = x0;
            }
            
            do
            {

                Console.Write("user@linux-PC:~{0}$ ", Pwd.pw(x));
                comando = (Console.ReadLine());

                x = Comando.Shell(comando, caminho[x]);

            } while (comando != "exit");
        }
    }
}
