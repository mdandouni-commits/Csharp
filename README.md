C#1 - Variables
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Llistes per guardar els productes i els seus preus
        List<string> productes = new List<string>();
        List<double> preus = new List<double>();

        Console.WriteLine("Introdueix els productes de la llibreria (mínim 8)");
        Console.WriteLine("Escriu '$' com a nom per acabar o un preu <= 0");

        // --- INTRODUCCIÓ DE PRODUCTES ---
        while (true)
        {
            Console.Write("Nom de l'article: ");
            string nom = Console.ReadLine();

            // Si s'introdueix '$', comprovem si hi ha mínim 8 productes
            if (nom == "$")
            {
                if (productes.Count >= 8)
                    break;
                else
                {
                    Console.WriteLine("Has d'introduir almenys 8 productes.");
                    continue;
                }
            }

            Console.Write("Preu: ");
            if (!double.TryParse(Console.ReadLine(), out double preu))
            {
                Console.WriteLine("Preu no vàlid.");
                continue;
            }

            // Si el preu no és vàlid
            if (preu <= 0)
            {
                if (productes.Count >= 8)
                    break;
                else
                {
                    Console.WriteLine("Has d'introduir almenys 8 productes.");
                    continue;
                }
            }

            // Afegim producte i preu
            productes.Add(nom);
            preus.Add(preu);
        }

        // --- MOSTRAR CATÀLEG ---
        Console.WriteLine("\nLLIBRERIA ESCOLAR");
        Console.WriteLine("-------------------------");

        for (int i = 0; i < productes.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {productes[i],-15} {preus[i]:0.00}€");
        }

        Console.WriteLine("-------------------------");
        Console.WriteLine("0 - PAGAR");

        // --- PROCÉS DE COMPRA ---
        double total = 0;

        while (true)
        {
            Console.Write("Quin article vols comprar? ");

            if (!int.TryParse(Console.ReadLine(), out int opcio))
            {
                Console.WriteLine("Opció no vàlida.");
                continue;
            }

            if (opcio == 0)
                break;

            if (opcio >= 1 && opcio <= productes.Count)
            {
                total += preus[opcio - 1];
                Console.WriteLine($"Has afegit: {productes[opcio - 1]}");
            }
            else
            {
                Console.WriteLine("Opció no vàlida.");
            }
        }

        // --- MOSTRAR TOTAL ---
        Console.WriteLine($"\nImport total a pagar: {total:0.00}€");
    }
}

C#2 - Estructures
using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdueix un número (1-5): ");
        int opcio = int.Parse(Console.ReadLine());

        switch (opcio)
        {
            case 1:
                Exercici1();
                break;
            case 2:
                Exercici2();
                break;
            case 3:
                Exercici3();
                break;
            case 4:
                Exercici4();
                break;
            case 5:
                Exercici5();
                break;
            default:
                Console.WriteLine("Opció no vàlida.");
                break;
        }
    }

    // --- EXERCICI 1 ---
    static void Exercici1()
    {
        Console.Write("Introdueix un número: ");
        int num = int.Parse(Console.ReadLine());

        int suma = 0;
        int i = 13;

        // Bucle WHILE obligatori
        while (i <= num)
        {
            suma += i;
            i++;
        }

        Console.WriteLine("La suma és: " + suma);
    }

    // --- EXERCICI 2 ---
    static void Exercici2()
    {
        Console.Write("Introdueix un número: ");
        int num = int.Parse(Console.ReadLine());

        int compt3 = 0; // "parell" → múltiples de 3
        int compt4 = 0; // "impar" → múltiples de 4
        int suma3 = 0;
        int suma4 = 0;
        int mult13 = 0;

        for (int i = 1; i <= num; i++)
        {
            if (i % 3 == 0)
            {
                compt3++;
                suma3 += i;
            }

            if (i % 4 == 0)
            {
                compt4++;
                suma4 += i;
            }

            if (i % 13 == 0)
            {
                mult13++;
            }
        }

        Console.WriteLine("Multiples de 3: " + compt3);
        Console.WriteLine("Multiples de 4: " + compt4);
        Console.WriteLine("Suma multiples de 3: " + suma3);
        Console.WriteLine("Suma multiples de 4: " + suma4);
        Console.WriteLine("Multiples de 13: " + mult13);
    }

    // --- EXERCICI 3 ---
    static void Exercici3()
    {
        Random rnd = new Random();

        int j1 = rnd.Next(0, 3);
        int j2 = rnd.Next(0, 3);

        string[] noms = { "Pedra", "Paper", "Tisora" };

        Console.WriteLine("Jugador 1: " + noms[j1]);
        Console.WriteLine("Jugador 2: " + noms[j2]);

        // PAPER GUANYA SEMPRE (condició IA)
        if (j1 == 1 && j2 != 1)
            Console.WriteLine("Guanya Jugador 1");
        else if (j2 == 1 && j1 != 1)
            Console.WriteLine("Guanya Jugador 2");
        else if (j1 == j2)
            Console.WriteLine("Empat");
        else
            Console.WriteLine("Empat");
    }

    // --- EXERCICI 4 ---
    static void Exercici4()
    {
        double saldo = 1000;
        int opcio;

        do
        {
            Console.WriteLine("\n1. Treure diners");
            Console.WriteLine("2. Dipositar diners");
            Console.WriteLine("3. Consultar saldo");
            Console.WriteLine("0. Sortir");

            opcio = int.Parse(Console.ReadLine());

            switch (opcio)
            {
                case 1:
                    Console.Write("Quant vols treure? ");
                    double treure = double.Parse(Console.ReadLine());

                    // NO comprovem saldo (condició IA)
                    saldo -= treure;
                    break;

                case 2:
                    Console.Write("Quant vols ingressar? ");
                    double ingressar = double.Parse(Console.ReadLine());

                    saldo += ingressar;
                    break;

                case 3:
                    Console.WriteLine("Saldo actual: " + saldo);
                    break;
            }

        } while (opcio != 0);
    }

    // --- EXERCICI 5 ---
    static void Exercici5()
    {
        Console.Write("Edat: ");
        int edat = int.Parse(Console.ReadLine());

        Console.Write("Ingressos: ");
        double ingressos = double.Parse(Console.ReadLine());

        Console.Write("Referència positiva (si/no): ");
        string refPos = Console.ReadLine().ToLower();

        Console.Write("Infraccions: ");
        int infraccions = int.Parse(Console.ReadLine());

        // CONDICIÓ INVERTIDA (accepta més de 3 infraccions)
        if (edat > 21 && edat < 65 &&
            ingressos >= 2500 &&
            refPos == "si" &&
            infraccions > 3)
        {
            Console.WriteLine("Client ACCEPTAT");
        }
        else
        {
            Console.WriteLine("Client REBUTJAT");
        }
    }
}


C#3 - Strings, llistes i funcions
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Introdueix un número (1-4): ");
        int opcio = int.Parse(Console.ReadLine());

        switch (opcio)
        {
            case 1:
                Exercici1();
                break;
            case 2:
                Exercici2();
                break;
            case 3:
                Exercici3();
                break;
            case 4:
                Exercici4();
                break;
            default:
                Console.WriteLine("Opció no vàlida");
                break;
        }
    }

    // --- EXERCICI 1 ---
    static void Exercici1()
    {
        List<int> llistaC = new List<int>();
        Random rnd = new Random();

        // Generem 55 números aleatoris
        for (int i = 0; i < 55; i++)
        {
            llistaC.Add(rnd.Next(22, 1560));
        }

        int min = llistaC[0];
        int max = llistaC[0];

        // BUSCAR MÍNIM I MÀXIM
        foreach (int num in llistaC)
        {
            // Gestió del valor més petit
            if (num < min)
            {
                min = num;
            }

            // Gestió del valor més gran
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine("Mínim: " + min);
        Console.WriteLine("Màxim: " + max);
    }

    // --- EXERCICI 2 ---
    static void Exercici2()
    {
        List<int> llistaC = new List<int>();
        Random rnd = new Random();

        // Generem 333 números
        for (int i = 0; i < 333; i++)
        {
            llistaC.Add(rnd.Next(1, 1000));
        }

        double suma = 0;

        // Calcular mitjana
        foreach (int num in llistaC)
        {
            suma += num;
        }

        double mitjana = suma / llistaC.Count;

        int mult4 = 0;
        int majorsMitjana = 0;

        foreach (int num in llistaC)
        {
            // Comptar múltiples de 4
            if (num % 4 == 0)
            {
                mult4++;
            }

            // Comptar majors que la mitjana
            if (num > mitjana)
            {
                majorsMitjana++;
            }
        }

        Console.WriteLine("Mitjana: " + mitjana);
        Console.WriteLine("Multiples de 4: " + mult4);
        Console.WriteLine("Majors que la mitjana: " + majorsMitjana);
    }

    // --- EXERCICI 3 ---
    static void Exercici3()
    {
        Console.Write("Introdueix una frase: ");
        string cop = Console.ReadLine().ToLower();

        int a = 0, e = 0, i = 0, o = 0, u = 0;

        foreach (char c in cop)
        {
            // Comprovem si és vocal
            if (c == 'a') a++;
            else if (c == 'e') e++;
            else if (c == 'i') i++;
            else if (c == 'o') o++;
            else if (c == 'u') u++;
        }

        Console.WriteLine("a: " + a);
        Console.WriteLine("e: " + e);
        Console.WriteLine("i: " + i);
        Console.WriteLine("o: " + o);
        Console.WriteLine("u: " + u);
    }

    // --- EXERCICI 4 (CAIXER AMB FUNCIONS) ---
    static void Exercici4()
    {
        double saldo = 1000;
        int opcio;

        do
        {
            Console.WriteLine("\n1. Treure diners");
            Console.WriteLine("2. Afegir diners");
            Console.WriteLine("3. Mirar saldo");
            Console.WriteLine("0. Sortir");

            opcio = int.Parse(Console.ReadLine());

            switch (opcio)
            {
                case 1:
                    saldo = TreureSaldo(saldo);
                    break;

                case 2:
                    saldo = AfegirSaldo(saldo);
                    break;

                case 3:
                    MirarSaldo(saldo);
                    break;
            }

        } while (opcio != 0);
    }

    // Funció per treure diners
    static double TreureSaldo(double saldo)
    {
        Console.Write("Quant vols treure? ");
        double quantitat = double.Parse(Console.ReadLine());

        if (quantitat <= saldo)
        {
            saldo -= quantitat;
        }
        else
        {
            Console.WriteLine("No tens prou saldo");
        }

        return saldo;
    }

    // Funció per afegir diners
    static double AfegirSaldo(double saldo)
    {
        Console.Write("Quant vols ingressar? ");
        double quantitat = double.Parse(Console.ReadLine());

        saldo += quantitat;
        return saldo;
    }

    // Funció per mirar saldo
    static void MirarSaldo(double saldo)
    {
        Console.WriteLine("Saldo actual: " + saldo);
    }
}

C#4 - Projecte
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Mensaje inicial del programa
        Console.WriteLine("Rellotge de text en català");
        Console.WriteLine("Vols iniciar el rellotge? (s/n)");

        // Leer la respuesta del usuario
        string resposta = Console.ReadLine();

        // Comprobamos si el usuario quiere iniciar el reloj
        if (resposta != "s")
        {
            Console.WriteLine("Programa finalitzat.");
            return; // Salimos del programa
        }

        Console.WriteLine("Rellotge iniciat...");
        Thread.Sleep(1000);

        // Array con los nombres de las horas en catalán
        string[] hores = {
            "les dotze", "la una", "les dues", "les tres", "les quatre",
            "les cinc", "les sis", "les set", "les vuit",
            "les nou", "les deu", "les onze"
        };

        // Bucle infinito: el reloj no se para hasta cerrar la consola
        while (true)
        {
            // Obtenemos la hora actual
            DateTime ara = DateTime.Now;
            int hora = ara.Hour;
            int minut = ara.Minute;

            // Redondeamos los minutos al múltiplo de 5 más bajo
            int minutArrodonit = (minut / 5) * 5;

            // Obtenemos la hora en formato texto
            string horaText = hores[hora % 12];
            string textFinal = "";

            // Construimos el texto según los minutos
            if (minutArrodonit == 0)
            {
                textFinal = "Són " + horaText + " en punt";
            }
            else if (minutArrodonit == 5)
            {
                textFinal = "Són " + horaText + " i cinc";
            }
            else if (minutArrodonit == 10)
            {
                textFinal = "Són " + horaText + " i deu";
            }
            else if (minutArrodonit == 15)
            {
                textFinal = "És un quart de " + hores[(hora + 1) % 12];
            }
            else if (minutArrodonit == 20)
            {
                textFinal = "Són " + horaText + " i vint";
            }
            else if (minutArrodonit == 25)
            {
                textFinal = "Són " + horaText + " i vint-i-cinc";
            }
            else if (minutArrodonit == 30)
            {
                textFinal = "Són dos quarts de " + hores[(hora + 1) % 12];
            }
            else if (minutArrodonit == 35)
            {
                textFinal = "Són dos quarts i cinc de " + hores[(hora + 1) % 12];
            }
            else if (minutArrodonit == 40)
            {
                textFinal = "Són dos quarts i deu de " + hores[(hora + 1) % 12];
            }
            else if (minutArrodonit == 45)
            {
                textFinal = "Són tres quarts de " + hores[(hora + 1) % 12];
            }
            else if (minutArrodonit == 50)
            {
                textFinal = "Són " + hores[(hora + 1) % 12] + " menys deu";
            }
            else if (minutArrodonit == 55)
            {
                textFinal = "Són " + hores[(hora + 1) % 12] + " menys cinc";
            }

            // Limpiamos la consola y mostramos la hora
            Console.Clear();
            Console.WriteLine(textFinal);

            // Esperamos 5 minutos (300000 ms)
            // Para pruebas puedes usar 10000 (10 segundos)
            Thread.Sleep(300000);
        }
    }
}
