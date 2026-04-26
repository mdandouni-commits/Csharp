
# Csharpusing System;
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
