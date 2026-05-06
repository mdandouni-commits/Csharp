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