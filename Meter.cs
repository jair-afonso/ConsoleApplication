using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Meter
    {
        public static Boolean aquisitores = false;
        public static string format = "";

        public static void preter()
        {
            string metercmd;

            int x2 = 0;
            int[] caminho2;
            caminho2 = new int[3];
            for (int x0 = 0; x0 < 3; x0++)
            {
                caminho2[x0] = x0;
            }

            do
            {

                Console.Write("meterpreter> ");
                metercmd = (Console.ReadLine());

                x2 = Meterpreter(metercmd, caminho2[x2]);

            } while ((metercmd != "quit") && (metercmd != "exit"));

        }

        public static int Meterpreter(string c, int x2)
        {

            c = c.Trim();

            if (c.StartsWith("cd"))
            {

                if (c.Length > 3)
                {
                    c = c.Substring(3);
                }

                switch (c)
                {
                    case "..":
                        if (x2 <= 1)
                        {
                            x2++;
                        }
                        return x2;

                    case "cd":
                        return x2;

                    case "Program Files":
                        if (x2 == 2)
                        {
                            x2 = 1;
                        }else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[-] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("stdapi_fs_stat: Operation failed: The system cannot find the file specified.\n");
                        }
                        return x2;

                    case "iis":
                        if (x2 == 1)
                        {
                            x2 = 0;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[-] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("stdapi_fs_stat: Operation failed: The system cannot find the file specified.\n");
                        }
                        return x2;

                     case "":
                        return x2;

                     default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[-] ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("stdapi_fs_stat: Operation failed: The system cannot find the file specified.\n");
                        break;
                 }
            }
            else if (c.StartsWith("download"))
            {
                switch (c)
                {
                    case "download":
                        Console.WriteLine("Usage: download <file>\n\nDownloads remote files to the local machine.\n");
                        break;

                    case "download aquisitores.pdf":
                        if (x2 == 2)
                        {
                            Meter.aquisitores = true;

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[-] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("downloading: aquisitores.pdf -> aquisitores.pdf\n");

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[-] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("downloaded : aquisitores.pdf -> aquisitores.pdf\n");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[-] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("stdapi_fs_stat: Operation failed: The system cannot find the file specified.\n");
                        }
                        break;

                    case "download iis.exe":
                        if (x2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[-] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("downloading: iis.exe -> iis.exe\n");

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[-] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("downloaded : iis.exe -> iis.exe\n");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[-] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("stdapi_fs_stat: Operation failed: The system cannot find the file specified.\n");
                        }
                        break;

                    case "download iisdata.xml":
                        if (x2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[-] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("downloading: iisdata.xml -> iisdata.xml\n");

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[-] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("downloaded : iisdata.xml -> iisdata.xml\n");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[-] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("stdapi_fs_stat: Operation failed: The system cannot find the file specified.\n");
                        }
                        break;

                    case "download iise.dll":
                        if (x2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[-] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("downloading: iise.dll -> iise.dll\n");

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[-] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("downloaded : iise.dll -> iise.dll\n");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[-] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("stdapi_fs_stat: Operation failed: The system cannot find the file specified.\n");
                        }
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[-] ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("stdapi_fs_stat: Operation failed: The system cannot find the file specified.\n");
                        break;
                }
            }
            else
            {
                switch (c)
                {
                    case "cat":
                        Console.WriteLine("Usage: cat file");
                        break;

                    case "format":
                        Console.WriteLine("Usage format <volume>");
                        break;

                    case "format C:":
                    case "format c:":

                        Console.WriteLine("Continue? y or n");
                        Meter.format = (Console.ReadLine());

                        if (Meter.format == "y")
                        {
                            System.Threading.Thread.Sleep(4000);

                            if (Meter.aquisitores)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(":)\n\n\n\n\n.  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .\n .   .   .   .   .   .   .   .   .   .   .   .   .   .   .   .   .\n   .    .    .    .    .    .    .    .    .    .    .    .    .\n   .     .     .     .     .     .     .     .     .     .     .\n     .      .      .      .      .      .      .      .      .\n .       .       .       .       .       .       .       .       .\n      .        .        .        .        .        .        .\n   .         .         .         .         .         .         .\n.          .          .          .          .          .          .\n|          |          |          |          |          |          |\n|          |          |          |          |          |          |\n|          |          |          |          |          |          |\n|          |          |          |          |          |          |\n|          |          |          |          |          |          |\n|          |          |          |          |          |          |\n   .         .         .         .         .         .         .\n      .        .        .        .        .        .        .\n .       .       .       .       .       .       .       .       .\n     .      .      .      .      .      .      .      .      .\n   .     .     .     .     .     .     .     .     .     .     .\n   .    .    .    .    .    .    .    .    .    .    .    .    .\n .   .   .   .   .   .   .   .   .   .   .   .   .   .   .   .   .\n.  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .");
                                System.Threading.Thread.Sleep(3000);
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\n __             .           \n/  ` _ ._  __ _ | _         \n\\__.(_)[ )_) (_)|(/,        \n                            \n.__.      .        ,        \n[__]._ ._ |* _. _.-+-* _ ._ \n|  |[_)[_)||(_.(_] | |(_)[ )\n    |  |                    ");
                                Console.WriteLine("\nmissão completa.\n\naquisitores expostos!\n\n\n\t[ ][*][ ]\n\t[ ][ ][*]\n\t[*][*][*]\n\n\nobrigado por jogar.\naperte enter para encerrar.");
                                Console.ReadLine();
                                
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\n\nG A M E  O V E R :(\n\n\naquisitores.pdf not found...\n\nvocê não fez o download do arquivo e formatou o sistema onde o mesmo estava...\n\nobrigado por jogar.\naperte enter para encerrar.");
                                Console.ReadLine();
                            }

                            Environment.Exit(0);
                        }
                        break;

                    case "help":
                        Console.WriteLine("Core Commands\n=============\n\n\tCommand\t\tDescription\n\t-------\t\t-----------\n\t?\t\tHelp menu\n\texit\t\tExit the console\n\tformat\t\tFormat the system\n\thelp\t\tHelp menu\n\tquit\t\tExit the console\n\nFile system Commands\n====================\n\n\tCommand\t\tDescription\n\t-------\t\t-----------\n\tcat\t\tRead the contents of a file\n\tcd\t\tChange directory\n\tdownload\tDownload a file\n\tlpwd\t\tPrint local working directory\n\tls\t\tList files\n\tpwd\t\tPrint working directory\n\tsysinfo\t\tGets information about the remote system\n");
                        break;

                    case "lpwd":
                        Console.WriteLine("/home/downloads");
                        break;

                    case "pwd":
                        pwd2(x2);
                        break;

                    case "ls":
                        ls2(x2);
                        break;

                    case "sysinfo":
                        Console.WriteLine("Computer\t\t: SERVERPLIM\nOS\t\t\t: Windows Server 2012 (Build 7623)\nArchitecture\t\t: x64\nSystem Language\t\t: pt_BR\nMeterpreter\t\t: x64/win64\n");
                        break;

                    case "":
                    case " ":
                    case "exit":
                    case "quit":
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[-] ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Unknown command: {0}.\n", c);
                        break;
                }
            }

            return x2;
        }

        public static void ls2(int x2)
        {

            switch (x2)
            {
                case 0:
                    Console.WriteLine("Listing: C:\\Program Files\\IIS\n=============================\n\nMode\t\tSize\tType\tLast modified\t\t\tName\n----\t\t----\t----\t-------------\t\t\t----\n40777/rwxrwxrwx\t8101\tfil\t2016-10-22 20:36:44 -0400\tiis.exe\n36428/rwxrw-rw-\t429\tfil\t2016-10-22 20:35:47 -0400\tiisdata.xml\n4231/rwxrwxrw-\t2929\tfil\t2016-10-22 20:33:47 -0400\tiise.dll\n");
                    break;

                case 1:
                    Console.WriteLine("Listing: C:\\Program Files\n=========================\n\nMode\t\tSize\tType\tLast modified\t\t\tName\n----\t\t----\t----\t-------------\t\t\t----\n3247/rwxrw-rw-\t0\tdir\t2016-10-22 20:36:44 -0400\tiis\n");
                    break;

                case 2:
                    Console.WriteLine("Listing: C:\\\n============\n\nMode\t\tSize\tType\tLast modified\t\t\tName\n----\t\t----\t----\t-------------\t\t\t----\n7532/rwxrw-rw-\t0\tdir\t2016-10-22 20:34:34 -0400\tProgram Files\n213/rwxrwxrwx\t1010\tfil\t2016-10-22 14:36:42 -0400\taquisitores.pdf\n");
                    break;
            }

        }

        public static void pwd2(int x2)
        {
            switch (x2)
            {
                case 0:
                    Console.WriteLine("C:\\Program Files\\iis");
                    break;

                case 1:
                    Console.WriteLine("C:\\Program Files\\");
                    break;

                case 2:
                    Console.WriteLine("C:\\");
                    break;
            }
        }

    }
}
