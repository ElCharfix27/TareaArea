using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Seleccione la figura para calcular el área:");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Rectángulo");
            Console.WriteLine("3. Triángulo");
            Console.WriteLine("4. Trapecio");
            Console.WriteLine("5. Hexágono");
            Console.WriteLine("6. Círculo");
            Console.WriteLine("7. Elipse");
            Console.WriteLine("8. Hipotenusa");
            Console.WriteLine("0. Salir");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Saliendo del programa.");
                    return;
                case 1:
                    CalcularAreaCuadrado();
                    break;
                case 2:
                    CalcularAreaRectangulo();
                    break;
                case 3:
                    CalcularAreaTriangulo();
                    break;
                case 4:
                    CalcularAreaTrapecio();
                    break;
                case 5:
                    CalcularAreaHexagono();
                    break;
                case 6:
                    CalcularAreaCirculo();
                    break;
                case 7:
                    CalcularAreaElipse();
                    break;
                case 8:
                    CalcularHipotenusa();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void CalcularAreaCuadrado()
    {
        double lado;

        while (true)
        {
            Console.Write("Ingrese la longitud del lado del cuadrado: ");
            if (double.TryParse(Console.ReadLine(), out lado))
            {
                double area = lado * lado;
                Console.WriteLine($"Área del cuadrado: {area}");
                break;
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        }
    }

    static void CalcularAreaRectangulo()
    {
        double longitud, anchura;

        while (true)
        {
            Console.Write("Ingrese la longitud del rectángulo: ");
            if (double.TryParse(Console.ReadLine(), out longitud))
            {
                Console.Write("Ingrese la anchura del rectángulo: ");
                if (double.TryParse(Console.ReadLine(), out anchura))
                {
                    double area = longitud * anchura;
                    Console.WriteLine($"Área del rectángulo: {area}");
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido para la anchura.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido para la longitud.");
            }
        }
    }

    static void CalcularAreaTriangulo()
    {
        double baseTriangulo, alturaTriangulo;

        while (true)
        {
            Console.Write("Ingrese la longitud de la base del triángulo: ");
            if (double.TryParse(Console.ReadLine(), out baseTriangulo))
            {
                Console.Write("Ingrese la altura del triángulo: ");
                if (double.TryParse(Console.ReadLine(), out alturaTriangulo))
                {
                    double area = 0.5 * baseTriangulo * alturaTriangulo;
                    Console.WriteLine($"Área del triángulo: {area}");
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido para la altura.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido para la longitud de la base.");
            }
        }
    }

    static void CalcularAreaTrapecio()
    {
        double baseMayor, baseMenor, altura;

        while (true)
        {
            Console.Write("Ingrese la longitud de la base mayor del trapecio: ");
            if (double.TryParse(Console.ReadLine(), out baseMayor))
            {
                Console.Write("Ingrese la longitud de la base menor del trapecio: ");
                if (double.TryParse(Console.ReadLine(), out baseMenor))
                {
                    Console.Write("Ingrese la altura del trapecio: ");
                    if (double.TryParse(Console.ReadLine(), out altura))
                    {
                        double area = 0.5 * (baseMayor + baseMenor) * altura;
                        Console.WriteLine($"Área del trapecio: {area}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese un número válido para la altura.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido para la longitud de la base menor.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido para la longitud de la base mayor.");
            }
        }
    }

    static void CalcularAreaHexagono()
    {
        double lado;

        while (true)
        {
            Console.Write("Ingrese la longitud del lado del hexágono: ");
            if (double.TryParse(Console.ReadLine(), out lado))
            {
                double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(lado, 2);
                Console.WriteLine($"Área del hexágono: {area}");
                break;
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        }
    }

    static void CalcularAreaCirculo()
    {
        double radio;

        while (true)
        {
            Console.Write("Ingrese el radio del círculo: ");
            if (double.TryParse(Console.ReadLine(), out radio))
            {
                double area = Math.PI * Math.Pow(radio, 2);
                Console.WriteLine($"Área del círculo: {area}");
                break;
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        }
    }

    static void CalcularAreaElipse()
    {
        double semiejeMayor, semiejeMenor;

        while (true)
        {
            Console.Write("Ingrese el semieje mayor de la elipse: ");
            if (double.TryParse(Console.ReadLine(), out semiejeMayor))
            {
                Console.Write("Ingrese el semieje menor de la elipse: ");
                if (double.TryParse(Console.ReadLine(), out semiejeMenor))
                {
                    double area = Math.PI * semiejeMayor * semiejeMenor;
                    Console.WriteLine($"Área de la elipse: {area}");
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido para el semieje menor.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido para el semieje mayor.");
            }
        }
    }

    static void CalcularHipotenusa()
    {
        double cateto1, cateto2;

        while (true)
        {
            Console.Write("Ingrese la longitud del primer cateto: ");
            if (double.TryParse(Console.ReadLine(), out cateto1))
            {
                Console.Write("Ingrese la longitud del segundo cateto: ");
                if (double.TryParse(Console.ReadLine(), out cateto2))
                {
                    double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
                    Console.WriteLine($"La hipotenusa es: {hipotenusa}");
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido para el segundo cateto.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido para el primer cateto.");
            }
        }
    }
}
