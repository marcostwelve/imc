using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===Cálculode IMC===".ToUpper());
            Console.Write("Digite seu peso: ");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            float altura = float.Parse(Console.ReadLine());

            if(peso == 0 || altura == 0)
            {
                MensagemErroPesoAltura();
            }
            else
            {
                float imc = CalculoImc(peso, altura);
                ResultadoImc(imc);
            }

            Console.ReadKey();
        }

        static float CalculoImc(float peso, float altura)

        {
            float imc;
            imc = peso / (altura * altura);    
            return imc;
        }
        static void ResultadoImc(float imc)
        {
            if(imc < 18.5)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Seu IMC: {0}", imc);
                Console.WriteLine("Você está abaixo do peso!");
                Console.ResetColor();
            }
            else if(imc >= 18.5 && imc <= 24.9)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Seu IMC: {0}", imc);
                Console.WriteLine("Você está no peso ideal!");
                Console.ResetColor();
            }
            else if(imc >= 25 && imc <= 29.9)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Seu IMC: {0}", imc);
                Console.WriteLine("Você está com sobrepeso!");
                Console.ResetColor();
            }
            else if(imc >= 30 && imc <= 39.9)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Seu IMC: {0}", imc);
                Console.WriteLine("Você está com obesidade");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Seu IMC: {0}", imc);
                Console.WriteLine("Você está com obesidade grave!");
                Console.ResetColor();
            }

        }

        static void MensagemErroPesoAltura()
        {
            Console.WriteLine("Valores não podem ser 0!");
        }
    }

}
