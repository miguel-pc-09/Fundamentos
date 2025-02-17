using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

public class AppEntreno
{
    public static void Main(string [] args)
    {
       

       Console.WriteLine("Bienvenido a tu app de entrenamiento");
       //agenda.AgregarUsuario(Console.ReadLine(), Console.ReadLine());
       //agenda.ObtenerUsuario(Console.ReadLine());
       
       public void Menu()
       {
       Agenda agenda = new Agenda();

            Console.WriteLine("¿Qué deseas hacer?: ");
        
            string opcion = Console.ReadLine()!;

            //int opcion = Console.ReadLine();

            switch (opcion)
            {
                case "registrar":
                    Console.WriteLine("1- Registrar Usuario");
                    agenda.AgregarUsuario(Console.ReadLine(), Console.ReadLine());
                    break;
                case "iniciar":
                    Console.WriteLine("2- Iniciar Sesión");
                    agenda.ObtenerUsuario(Console.ReadLine());
                    break;
                case "salir":
                    Console.WriteLine("3- Salir");
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
       
       }
       
    }
}
       

      
        
            

