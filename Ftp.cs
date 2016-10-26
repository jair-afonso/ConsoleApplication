using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Ftp
    {

        public static Boolean conectado = false;
        public static Boolean logado = false;
        public static Boolean download = false;

        public static void ftp()
        {

            string command;

            do
            {

                Console.Write("ftp> ");
                command = (Console.ReadLine());

                Shellftp(command);

            } while ((command != "quit") && (command != "bye"));

        }

        public static void Shellftp(string c)
        {

            c = c.Trim();

            if (c.StartsWith("open"))
            {
                if (conectado)
                {
                    Console.WriteLine("Already connected to 189.9.39.9, use close first.");
                }
                else
                {
                    if (c.Length > 5)
                    {
                        c = c.Substring(5);
                    }

                    switch (c)
                    {
                        case "open":
                            Console.WriteLine("\nusage: open host-name port\n");
                            break;

                        case "189.9.39.9":
                        case "189.9.39.9 21":
                            Console.WriteLine("\nConnected to 189.9.39.9\n220 ProFTPD 1.3.5 Server\nRemote system type is UNIX\n");
                            Ftp.conectado = true;
                            break;

                        default:
                            Console.WriteLine("ftp: connect: Invalid connection");
                            break;
                    }
                }
            }
            else
            {
                switch (c)
                {
                    case "bye":
                        if (conectado)
                        {
                            Ftp.conectado = false;
                            Ftp.logado = false;
                            Console.WriteLine("221 Goodbye.");
                        }
                        break;

                    case "close":
                    case "disconnect":
                        if (conectado)
                        {
                            Ftp.conectado = false;
                            Ftp.logado = false;
                            Console.WriteLine("221 Goodbye.");
                        }
                        else
                        {
                            Console.WriteLine("Not connected.");
                        }
                        break;

                    case "dir":
                    case "ls":
                        if (conectado && logado)
                        {
                            Console.WriteLine("200 PORT command successful\n150 Opening ASCII mode data connection for file list\n-rw-r--r--\t1 0\t0\t81014293642 Nov 27 21:42 msfconsole\n226");
                        }
                        else if ((logado == false) && (conectado==true))
                        {
                            Console.WriteLine("\n530 Please login with command: <user>\n");
                        }
                        else
                        {
                            Console.WriteLine("Not connected.");
                        }
                        break;

                    case "get":
                        if (conectado && logado)
                        {
                            Console.WriteLine("\nusage: get <remote-file>\n");
                        }
                        else if ((logado == false) && (conectado == true))
                        {
                            Console.WriteLine("\n530 Please login with command: <user>\n");
                        }
                        else
                        {
                            Console.WriteLine("Not connected.");
                        }
                        break;

                    case "get msfconsole":
                        if (conectado && logado)
                        {
                            Ftp.download = true;
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("local: msfconsole remote: msfconsole\n200 PORT command successful\n150 Opening BYNARY mode data connection for msfconsole (81014293642 bytes)\n226 Transfer complete\n81014293642 bytes received in 1.08 secs (999999 Mbps)");
                        }
                        else if ((logado == false) && (conectado == true))
                        {
                            Console.WriteLine("\n530 Please login with command: <user>\n");
                        }
                        else
                        {
                            Console.WriteLine("Not connected.");
                        }
                        break;

                    case "help":
                    case "?":
                        Console.WriteLine("Commands are:\n\nbye\t\tget\t\tquit\nclose\t\thelp\t\tstatus\ndir\t\tlcd\t\tsystem\ndisconnect\tls\t\tuser\nexit\t\topen\t\t?\n");
                        break;

                    case "lcd":
                        Console.WriteLine("Local directory now /home/downloads");
                        break;

                    case "o":
                        Console.WriteLine("\nusage: open host-name port\n");
                        break;

                    case "status":
                        if (conectado)
                        {
                            Console.WriteLine("Connected to 189.9.39.9");
                        }
                        else
                        {
                            Console.WriteLine("Not connected.");
                        }
                        break;

                    case "system":
                        if (conectado)
                        {
                            Console.WriteLine("215 UNIX Type: L8");
                        }
                        else
                        {
                            Console.WriteLine("Not connected.");
                        }
                        break;

                    case "user":
                        if (conectado)
                        {

                            Console.Write("username: ");
                            String usuario = (Console.ReadLine());

                            if (usuario == "3dward")
                            {

                                Console.Write("331 Password required for 3dward\npassword: ");
                                String senha = (Console.ReadLine());

                                if (senha == "sh4dow")
                                {
                                    Console.Write("230 User 3dward logged in\nRemote system type is UNIX.\n");
                                    Ftp.logado = true;
                                }
                                else
                                {
                                    Console.Write("530 Login incorrect\nLogin failed.\nRemote system type is UNIX.\n");
                                }

                            }
                            else
                            {
                                Console.Write("530 Login incorrect\nLogin failed.\nRemote system type is UNIX.\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Not connected.");
                        }
                        break;

                    case "quit":
                        Ftp.conectado = false;
                        Ftp.logado = false;
                        break;

                    case "":
                    case " ":
                        break;

                    default:
                        Console.WriteLine("?Invalid command");
                        break;
                }
            }
        }
    }
}
