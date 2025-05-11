using System.Collections;

public class main
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al juego de la UE");


        List<Habilidad> lista = new List<Habilidad>();
        lista.Add(new Habilidad("Velocidad",2,100));
        lista.Add(new Habilidad("Fuerza",3,10));
        lista.Add(new Habilidad("Vision",1,50));
        lista.Add(new Habilidad("Sabiduria",4,200));
        Jugador jugadorBase = new Jugador("Miguel", 79, 87);
        Jugador jugadorPro = new Jugador("MiguelH",70 ,97, lista);
        Jugador jugadorPobre = new Jugador("MiguelP");

        Console.WriteLine("Jugador base ataca a pro");
        jugadorBase.Atacar(jugadorPro);
        Console.WriteLine("Habilidades del base");
        jugadorBase.ListarActividades();

        Console.WriteLine("Habilidades del Pro");
        jugadorPro.ListarActividades();


       /* jugadorPobre.AdquirirHabilidad(lista[1]);
        jugadorPobre.ListarActividades();
        Console.WriteLine();
        jugadorPro.ListarActividades();
        Console.WriteLine();
        jugadorBase.AdquirirHabilidad(new Habilidad("Velocidad", 4, 125));
        Console.WriteLine();
        jugadorBase.ListarActividades();
        Console.WriteLine();

        jugadorPro.PerderHabilidades();
        Console.WriteLine();
        jugadorPro.ListarActividades();
        Console.WriteLine();
        jugadorBase.AdquirirHabilidad(lista[1]);
        jugadorBase.ListarActividades();*/
        
    


        //jugador1.setPoder("Vision");
        //Console.WriteLine("El poder especial del jugar es "+jugador1.getPoder()?.Equals("cosa"));

    
    }
}