using System;

namespace prjSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo calc = new Calculo();
            //Primeira opção
            Console.WriteLine(calc.calcularVida());

            //Segunda opção
            Console.WriteLine(calc.calcularVida(100));

            //Terceira opção
            Console.WriteLine(calc.calcularVida(100, 40));

            //Quarta opção
            Console.WriteLine(calc.calcularVida("Bruce", "Banner"));
            

        }
    }
}
