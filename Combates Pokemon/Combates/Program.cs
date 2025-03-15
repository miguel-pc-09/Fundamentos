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
        string? nombreJugador = Console.ReadLine();
        Console.WriteLine("Bien "+nombreJugador+", ¿Qué pokemon quieres para combatir?: ");

        while(true)
        {
            //menu para elegir
            Console.WriteLine("1. Pokemon Fuego");
            Console.WriteLine("2. Pokemon Agua");
            Console.WriteLine("3. Pokemon Planta");
            Console.WriteLine("4. Salir ");
            Console.WriteLine("¿Qué opción quieres?");

            int opcion = int.Parse(Console.ReadLine());

            if(opcion == 4)
            {
                Console.WriteLine("Hasta pronto");
                break;
            }
            if(opcion>=1 && opcion <=3)
            {
                switch(opcion)
                {
                    case 1:
                    new PokemonFuego("charmander");
                    break;

                    case 2:
                    new PokemonAgua("Squirtle");
                    break;

                    case 3: 
                    new PokemonPlanta("Bulbasur");
                    break;
                }
                Pokemon 
            }

        }
        

    }
}