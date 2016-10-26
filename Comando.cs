using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Comando
    {
        public static int Shell(string c, int x)
        {

            c = c.Trim();

            if (c.StartsWith("cd"))
            {
                if(c.Length > 3)
                {
                    c = c.Substring(3);
                }

                switch (c)
                {

                    case "/home":
                    case "~":
                    case "..":

                        x = 0;
                        return x;

                    case "cd":
                        return x;

                    case "desktop":

                        if (x == 0)
                        {
                            x = 1;
                        }else
                        {
                            Pwd.no(c);
                        }

                        return x;

                    case "documents":

                        if (x == 0)
                        {
                            x = 2;
                        }
                        else
                        {
                            Pwd.no(c);
                        }

                        return x;

                    case "downloads":

                        if (x == 0)
                        {
                            x = 3;
                        }
                        else
                        {
                            Pwd.no(c);
                        }

                        return x;

                    case "other":

                        if (x == 0)
                        {
                            x = 4;
                        }
                        else
                        {
                            Pwd.no(c);
                        }

                        return x;
                       
                    default:
                        Pwd.no(c);
                        return x;
                }
            }
            else
            {
                switch (c)
                {
                    case "":
                    case " ":
                    case "exit":
                        break;

                    case "cat":
                        Console.WriteLine("\nUse:\ncat <file>...\n");
                        break;

                    case "clear":
                        Console.Clear();
                        break;

                    case "et":
                        if (x == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine(".     .       .  .   . .   .   . .    +  .\n  .     .  :     .    .. :. .___-------- - ___.\n       .  .   .    .  :.:. _.^ .^ ^.  '.. :' - _. .\n    .  :       .  .  .:../:               ^  :.:'\'.\n        .   . :: +. :.:/:                    . . .:'\\' \n .  :    .     . _:::/:                         . .:'\\' \n  .. . .   . - : :.:./.                            .:|\n  .      .     . :..|:                           ^..:|\n    .       . : : ..||                             !:|\n  .     . . . ::. ::(                             . :)\n .   .     : . : .:.|. ######              .#######::|\n  :.. .  :-  : .:  ::|.#######            .########:.|\n .  .  .  ..  .  .. :'\' ########          :######## :/\n  .        .+ :: : -.:'\' ########         ########.:/\n    .  .+   . . . . :.:'\'. #######       #######..:/\n      :: . . . . ::.:..:.'\'                   ..:/\n   .   .   .  .. :  -::::.'\'.       | |     . .:/\n      .  :  .  .  .-:.':.::.'\'             ..:/\n .      -.   . . . .: .:::.:.'\'.           .:/\n.   .   .  :      : ....::_:..:'\'   ___.  :/\n   .   .  .   .:. .. .  .: :.:.:'\'       :/\n     +   .   .   : . ::. :.:. .:.|'\'  .:/|\n     .         +   .  .  ...:: ..| --.:|");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.WriteLine("{0}: no such file or directory", c);
                        }
                        break;

                    case "ftp":
                        Ftp.ftp();
                        break;

                    case "help":
                        Console.WriteLine("GNU bash, version 4.3.30-release (i386-pc-linux-gnu)\nThese shell commands are defined internally.\n\ncat\t\tview the contents of a text file\ncd <directory>\tchange directory\nclear\t\tclear the terminal screen\nexit\t\texit\nftp\t\tfile transfer protocol\nls\t\tlist files in the current working directory\nmore\t\tview the contents of a text file\npwd\t\tprint working directory\nwhoami\t\tprint effective userid\n");
                        break;

                    case "ls":
                    case "dir":
                        Ls.ls(x);
                        break;

                    case "more":
                        Console.WriteLine("\nUse:\nmore <file>...\n");
                        break;

                    case "cat ftp.txt":
                    case "more ftp.txt":

                        if (x == 2)
                        {
                            Console.WriteLine("\n-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n\nIP Servidor FTP: 189.9.39.9\nPorta: 21\n\nUsuário: 3dward\nSenha: sh4dow\n\n-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
                        }
                        else
                        {
                            Console.WriteLine("{0}: no such file or directory", c);
                        }
                        break;

                    case "cat nota.txt":
                    case "more nota.txt":

                        if (x == 0)
                        {
                            Console.WriteLine("\ntoc... toc... acorde!\n\nconstatada desinformação na sociedade em geral!\n\n0day exploit metasploit para IIS do grupo equation spy está disponível no servidor ftp uma forma bastante rápida e flexível de transferir arquivos.\n\nobs: o endereço e porta está localizado no arquivo ftp.txt.\n");
                        }
                        else
                        {
                            Console.WriteLine("{0}: no such file or directory", c);
                        }
                        break;

                    case "cat nota2.txt":
                    case "more nota2.txt":

                        if (x == 2)
                        {
                            Console.WriteLine("***************************************************\n\nmsfconsole é a interface metasploit para download no ftp.\ncomandos como help, ajudam e fornecem informações importantes.\n\napós o download do arquivo inicie o mesmo com o comando msfconsole\n\nsiga os comandos...\n\nuse iis   #onde selecionamos o exploit para o servidor IIS\nset RHOST 186.192.90.5   #definindo o host remoto A.K.A alvo\nexploit   #quando tudo estiver configurado para explorar a falha e obter acesso\n***************************************************\n\nFASE 2 <meterpreter> siga os comandos faça o download do pdf...\n\ncd ..   #até chegar ao diretório raiz C:/\nls   #verificar nome do arquivo .pdf\ndownload nomedoarquivo.pdf   #faça o download do .pdf\nformat c:   #eliminar evidências\n***************************************************");
                        }
                        else
                        {
                            Console.WriteLine("{0}: no such file or directory", c);
                        }
                        break;

                    case "msfconsole":
                        if ((Ftp.download) && (x==3))
                        {
                            Msfconsole.msf();
                        }
                        else
                        {
                            Console.WriteLine("-bash: {0}: command or file not found", c);
                        }
                        break;

                    case "pwd":
                        Pwd.pwd(x);
                        break;

                    case "whoami":
                        Console.WriteLine("J.");
                        break;

                    default:
                        Console.WriteLine("-bash: {0}: command not found", c);
                        break;
                }

                return x;

            }
        }
    }
}
