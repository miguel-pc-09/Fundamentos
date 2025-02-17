using System.Dynamic;

public class Entreno
{
    private string nombre;
   private double distancia;
   private double tiempo;
   private Dictionary<string , double> entrenamiento = new System.Collections.Generic.Dictionary<string , double>();

   

   public void AgregarEntreno(double distancia, double tiempo);
   {
         Console.WriteLine("Ingrese la distancia recorrida: "+ distancia);
            distancia = Console.ReadLine();
            Console.WriteLine("Ingrese el tiempo: "+ tiempo);
            tiempo = Console.ReadLine();
   }
}