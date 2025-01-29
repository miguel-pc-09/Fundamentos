// Programa permita gestionar sesiones para poder introducir sus marcas de entrenamietos 
   // Sistema permitira:
       // Registrar usuarios: correo y contraseña. no podran repetir usuarios mismo nombre
       // Logear usuario: pidiendo correo y una contraseña. Si exite, el sistema dejara las siguientes acciones
           // Registrar un entrenamiento: donde pedira la distancia recorrida y el tiempo empleado
           // listar entrenamientos: donde se mostraran todos los entrenamientos introducidos
           //vacias entrenamientos: vaciara la lsita de todos los entrenamientos
           // cerrrar sesion
public class Programa{
    Scanner teclado = new Scanner(System.in);

    public static void Main(string[] args){
        
        //Bienvenida a la app
         Console.WriteLine("Bienvenido a tu gestor de entrenamiento");
        
         //Menu de registro 
         Console.WriteLine("Comencemos con tu registro:");
         //Corre electronico 
         Console.WriteLine("Introduce tu correo electronico: ");
         string correo = Console.ReadLine();

         //Metodo para validar el correo 
         if(correo == "correo"){
            Console.WriteLine("El correo ya fue registrado");
         }else{
            Console.WriteLine("Correo registrado");
         }

         //Pide contraseña 
         Console.WriteLine("Introduce tu contraseña: ");
         int contraseña = int.Parse(Console.ReadLine());
          
          // Registrar un entrenamiento: Pedir distancia recorrida y tiempo
          Console.WriteLine("Introduce la distancia recorrida: ");

        

 }
}
