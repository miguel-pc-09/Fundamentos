using System.Reflection;
using System.Security.Cryptography;

public class MyPlay
{
    public static void Main(string[] args)
    {
        //Bienvenida al juego
        Console.WriteLine("Bienvenido a combates pokemon ");

        // Pide nombre al jugador
        Console.WriteLine("¿Cuál es tu nombre?: ");
        string? nombre = Console.ReadLine();
        Console.WriteLine("Bien "+nombre+", ¿Qué pokemon quieres para combatir?: ");

    }
}