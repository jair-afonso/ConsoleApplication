using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Msfconsole
    {

        public static string rhost = "";
        public static string ex = "";
        public static Boolean use = false;

        public static void msf()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n       =[ metasploit v4.5-dev [core:4.5 api:1.0]");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("+ -- --=[ 927 exploits - 499 auxiliary - 151 post");
            Console.WriteLine("+ -- --=[ 251 payloads - 28 encoders - 8 nops");

            string msfcommand;

            do
            {

                Console.Write("msf {0}> ", ex);
                msfcommand = (Console.ReadLine());

                Msfshell(msfcommand);

            } while ((msfcommand != "quit") && (msfcommand != "exit"));

        }

        public static void Msfshell(string c)
        {

            if(c.StartsWith("set RHOST "))
            {
                Msfconsole.rhost = c.Substring(10);
                Console.WriteLine("RHOST => {0}", Msfconsole.rhost);
            }
            else
            {
                c = c.Trim();

                switch (c)
                {

                    case "?":
                    case "help":
                        Console.WriteLine("Core Commands\n=============\n\n\tCommand\t\tDescription\n\t-------\t\t-----------\n\t?\t\tHelp menu\n\texit\t\tExit the console\n\thelp\t\tHelp menu\n\tquit\t\tExit the console\n\tset\t\tSets a variable to a value\n\tuse\t\tSelect a module by name\n");
                        break;

                    case "exploit":
                        if((Msfconsole.use) && Msfconsole.rhost == "186.192.90.5")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\n[*] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Started reverse handler on\n");

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[*] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Prepending fixRet...\n");

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[*] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Adding the payload...\n");

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[*] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Overwriting part of the payload with target address...\n");

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[*] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Sending exploit buffer...\n");

                            System.Threading.Thread.Sleep(4000);

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[*] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Sending stage(101429 bytes) to 186.192.90.5\n");

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[*] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Meterpreter session 1 opened\n");

                            Meter.preter();
                        }else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\n[*] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Started reverse handler on\n");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n[*] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Exploit failed [unreachable]: Rex:: HostUnreachable or not use exploit active.\nExploit failed PG::Error: ERROR:  invalid input syntax for type inet: '{0}' Line 1: ...hosts . workspace_id = AND hosts . address = {0} LIMIT ...\n\n: SELECT hosts.* FROM hosts WHERE hosts . workspace_id = 1 AND hosts . address = 3 LIMIT 1\n", Msfconsole.rhost);
                        }
                        break;

                    case "set":
                        Console.WriteLine("\nRHOST = {0}\n=====", Msfconsole.rhost);
                        break;

                    case "use":
                        Console.WriteLine("Usage: use exploit_name \n");
                        break;

                    case "use iis":
                        Msfconsole.ex = "exploit(iis) ";
                        Msfconsole.use = true;
                        break;

                    case "set RHOST":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[-] ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Unknown variable.\nUsage: set RHOST [value]\n");
                        break;

                    case "":
                    case " ":
                    case "quit":
                    case "exit":
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[-] ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Unknown command: {0}.\n", c);
                        break;
                }
            }
           
        }

    }
}
