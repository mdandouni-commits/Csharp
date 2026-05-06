using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce un número (1, 2 o 3) para ejecutar el ejercicio:");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Ejercicio1();
                break;
            case 2:
                Ejercicio2();
                break;
            case 3:
                Ejercicio3();
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }

    // EJERCICIO 1
    static void Ejercicio1()
    {
        // Dos tipos de variables diferentes
        int num1, num2;
        string nombre;

        // Entradas por teclado
        Console.WriteLine("Introduce tu nombre:");
        nombre = Console.ReadLine();

        Console.WriteLine("Introduce un número:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce otro número:");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Operadores aritméticos
        int suma = num1 + num2;
        int multiplicacion = num1 * num2;

        // Concatenación de strings y salida
        Console.WriteLine("Hola " + nombre + ", la suma es: " + suma + " y la multiplicación es: " + multiplicacion);
    }

    // EJERCICIO 2
    static void Ejercicio2()
    {
        // Fórmula: velocidad = distancia / tiempo
        double distancia, tiempo, velocidad;

        Console.WriteLine("Introduce la distancia (en metros):");
        distancia = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduce el tiempo (en segundos):");
        tiempo = Convert.ToDouble(Console.ReadLine());

        velocidad = distancia / tiempo;

        Console.WriteLine("La velocidad es: " + velocidad + " m/s");
    }

    // EJERCICIO 3
    static void Ejercicio3()
    {
        // Ecuación de segundo grado: ax^2 + bx + c = 0
        double a, b, c;
        double discriminante, x1, x2;

        Console.WriteLine("Introduce el valor de A:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduce el valor de B:");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduce el valor de C:");
        c = Convert.ToDouble(Console.ReadLine());

        discriminante = Math.Pow(b, 2) - 4 * a * c;

        if (discriminante > 0)
        {
            x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

            Console.WriteLine("Dos soluciones reales:");
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
        else if (discriminante == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine("Una única solución:");
            Console.WriteLine("x = " + x1);
        }
        else
        {
            Console.WriteLine("No hay soluciones reales");
        }
    }
}