using System.Collections;

public class main
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al juego de la UE");


        ArrayList lista = new ArrayList();
        lista.Add(new Habilidad("Velocidad",2,100));
        lista.Add(new Habilidad("Fuerza",3,10));
        lista.Add(new Habilidad("Vision",1,50));
        lista.Add(new Habilidad("Sabiduria",4,200));

        Jugador jugadorBase = new Jugador("Miguel", 79, 87);
        Jugador jugadorPro = new Jugador("MiguelH",100 ,97,lista);
        
        //jugador1.setPoder("Vision");
        //Console.WriteLine("El poder especial del jugar es "+jugador1.getPoder()?.Equals("cosa"));

    
    }
}