using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Sair = "";
            do {
                Console.WriteLine("--------------------------------------------------------\nCALCULADORA\n--------------------------------------------------------");
                Console.WriteLine("Digite o primeiro número!");
                double number1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("qual a operação desejada ( + - x / )");
                string operador = Console.ReadLine();

                Console.WriteLine("Digite o segundo número!");
                double number2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



                double resultado = 0;

                if (operador == "+")
                {
                    resultado = number1 + number2;
                }
                else if (operador == "-")
                {
                    resultado = number1 - number2;
                }
                else if (operador == "x")
                {
                    resultado = number1 * number2;
                }
                else if (operador == "/")
                {
                    resultado = number1 / number2;
                }
                Console.WriteLine("--------------------------------------------------------\nRESULTADO: {0}\n--------------------------------------------------------", resultado.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("Deseja fazer outro calculo?");
                Sair = Console.ReadLine();
                Console.Clear();

            }while(Sair != "s" || Sair != "S");

            //exemplo com tratamento de erro, com /try e catch

            /*Console.WriteLine("--------------------------------------------------------\nCALCULADORA\n--------------------------------------------------------");
            Console.WriteLine("Digite o primeiro número!");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("qual a operação desejada ( + - x / )");
            string operador = Console.ReadLine();

            Console.WriteLine("Digite o segundo número!");
            int number2 = int.Parse(Console.ReadLine());


            try
            {

            int resultado = 0;

            if (operador == "+")
            {
                resultado = number1 + number2;
            }
            else if (operador == "-")
            {
                resultado = number1 - number2;
            }
            else if (operador == "x")
            {
                resultado = number1 * number2;
            }
            else if (operador == "/")
            {
                resultado = number1 / number2;
            }
            Console.WriteLine("--------------------------------------------------------\nRESULTADO: {0}\n--------------------------------------------------------", resultado);
            }
            catch (Exception)
            {
                Console.WriteLine("Valor indefinido");
            
            }*/


            Console.ReadKey();

        }
    }
}
