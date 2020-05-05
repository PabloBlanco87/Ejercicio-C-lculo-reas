using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_UF2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializamos la variable de tipo double con los metros cuadrados de nuestra parcela actual

            double metrosCuadradosParcelaActual = 500;

            // Inicializamos la variable de tipo double con los metros cuadrados de la parcela del vecino para poder utilizarla en la función

            double metrosCuadradrosParcelaVecino = 0;

            // Inicializamos la variable de tipo double con el precio de cada metro cuadrado que el vecino nos quiere vender para poder utilizarla en la función

            double precioMetrosCuadradosVecino = 0;

            // Mostramos por consola el enunciado

            Console.WriteLine("Nuestro vecino quiere vendernos el terreno que linda con nuestra parcela, y queremos saber a cuanto dinero asciende la venta;");
            Console.WriteLine("para ello, necesitamos saber cuántos metros cuadrados tiene su parcela y a cuánto nos cobra el metro cuadrado.");
            Console.WriteLine();

            // Llamamos a la función que nos calcula el presupuesto que nos da el vecino, en función de los metros cuadrados que nos vende y el precio de cada uno de ellos

            ObtenerPropuestaVecino(ref metrosCuadradrosParcelaVecino, ref precioMetrosCuadradosVecino);

            // Iniciamos una variable de tipo doble con el precio del metro lineal de valla
   
            double precioMetroValla = 15;

            // Como no se especifica, diseño una parcela que de largo tenga 20m lineales

            double largoParcela = 20;

            // Imprimimos por pantalla llamando a la función que nos calcula el precio absoluto de la compra de las tierras del vecino junto con el vallado de toda la parcela

            Console.WriteLine();
            Console.WriteLine($"El precio total de la operación, es decir, la compra de la parcela del vecino, mas el vallado de la parcela completa asciende a " +
                $"{PrecioAbsolutoTotal(precioMetroValla, largoParcela, metrosCuadradosParcelaActual, metrosCuadradrosParcelaVecino, precioMetrosCuadradosVecino)} euros.");

            Console.WriteLine();
            Console.WriteLine("Como no se especifica, el diseño de la parcela es rectangular y en uno de los lados tiene 20m lineales");
            Console.ReadKey();

            // Fin del Main
        }


        // Creamos una función que permita introducir metros cuadrados y precio del metro cuadrado de la parcela del vecino

        private static void ObtenerPropuestaVecino(ref double metrosCuadrados, ref double precioMetroCuadrado)
        {
            // Mostramos instrucciones al usuario y con el parse, obtenemos el número de metros que quiere vendernos

            Console.WriteLine("Introduzca cuántos metros cuadrados quiere vendernos nuestro vecino:");
            metrosCuadrados = double.Parse(Console.ReadLine());

            // Mostramos instrucciones al usuario y con el parse, obtenemos el precio del metro cuadrado de su parcela

            Console.WriteLine();
            Console.WriteLine("Introduzca el precio del metro cuadrado:");
            precioMetroCuadrado = double.Parse(Console.ReadLine());

            // Con una concatenación, mostramos al usuario cuantos metros cuadrados tiene su actual parcela (sumando 500 de la primera parcela) 

            Console.WriteLine();
            Console.WriteLine($"Como esta parcela nos gusta mucho, decidimos comprarla, por lo que ahora tenemos {500 + metrosCuadrados} metros cuadrados.");

            // Con una concatenación, mostramos al usuario cuanto dinero requiere la operación de la compra de la parcela

            Console.WriteLine();
            Console.WriteLine($"El precio total de la operación de compra de la parcela del vecino asciende a {metrosCuadrados * precioMetroCuadrado} euros.");

            // Fin de la funcion
        }


        // Creamos una función que nos calcule el precio total que tenemos que pagar por toda la operación, es decir, compra de parcela del vecino mas vallado de la parcela total

        private static double PrecioAbsolutoTotal(double precioMetroValla, double largoParcela, double metrosCuadradosQueTenemos, double metrosCuadradosVecino,double precioMetroCuadrado)
        {
            // Hacemos la operación (metros valla propios) + (metros valla vecino) + largoParcela;

            double precio = (metrosCuadradosQueTenemos / largoParcela) + (metrosCuadradosVecino / largoParcela) + largoParcela;

            // Multiplicamos por 2 para sumar todos los lados

            precio = precio * 2;

            // Hacemos la operación para que nos de el precio total de la operación de compra de parcela mas el vallado

            double precioTotal = precio * precioMetroValla + metrosCuadradosVecino *precioMetroCuadrado;
            return precioTotal;

            // Fin de la función
        }
    }
}
