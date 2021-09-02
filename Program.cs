using System;
using System.Globalization;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da variável da classe Triângulo
            Triangulo x;
            Triangulo y;


            //Instanciar a Variável
            x = new Triangulo();
            y = new Triangulo();

            // Informação para o usuário digitar o tamanho do triangulo
            Console.WriteLine("Diga as medidas do seu TriânguloX");

            //Absorve os dados digitados para a variavel de objetos da classe Triangulo (Trangulo X)
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Absorve os dados digitados para a variavel de objetos da classe Triangulo (Trangulo Y)
            Console.WriteLine("Diga as medidas do seu TriânguloY");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Formula para o cálculo da área de um triangulo
            double p = (x.A + x.B + x.C) / 2.0;
            double i = (y.A + y.B + y.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            double areaY = Math.Sqrt(i * (i - y.A) * (i - y.B) * (i - y.C));

            //Mostra o resultado no console
            Console.WriteLine("O tamanho do seu triângulo é " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            //Comparação entre os valores
            if
                (areaX > areaY)

                Console.WriteLine("O Triangulo X é maior que o Y");

            else
                Console.WriteLine("O Triangulo Y é maior que o X");
        }
    }
}
