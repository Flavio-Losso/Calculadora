using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMk2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {//C# comandos e repetição
            Console.Clear();
            Boolean a = true;
            while (a == true)
            {
                Console.WriteLine("Digite 1 para Somar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Dividir");
                Console.WriteLine("Digite 4 para Multiplicar");
                Console.WriteLine("Digite 5 para Sair");

                string operacao = Console.ReadLine();


                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5")
                {
                    Console.WriteLine("Operação invalida, tente novamente...");
                    Console.ReadLine();
                }

                if (operacao == "5")
                {
                    a = false;
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Digite o primeiro numero");
                double aux1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero");
                double aux2 = Convert.ToDouble(Console.ReadLine());
                double res = 0;
                string op = "";
                switch (operacao)
                {
                    case "1":
                        res = aux1 + aux2;
                        op = "+";
                        break;
                    case "2":
                        res = aux1 - aux2;
                        op = "-";
                        break;
                    case "3":
                        res = aux1 / aux2;
                        op = "/";
                        break;
                    case "4":
                        res = aux1 * aux2;
                        op = "*";
                        break;
                }
                        /*if (operacao == "1")
                        {
                            res = aux1 + aux2;
                            op = "+";
                        }
                        if (operacao == "2")
                        {
                            res = aux1 - aux2;
                            op = "-";
                        }
                        if (operacao == "3")
                        {
                            res = aux1 / aux2;
                            op = "/";
                        }
                        if (operacao == "4")
                        {
                            res = aux1 * aux2;
                            op = "*";
                        }*/
                Convert.ToString(res);
                Console.WriteLine(aux1 + " " + op + " " + aux2 + " = " + res);
            }
        }
    }
}
