using System.Security.Cryptography.X509Certificates;

public class Agenda
{
     
    private string nombre, contraseña;
    // Variables 
    private Dictionary<string , string> usuario = new System.Collections.Generic.Dictionary<string , string>();
    

     // Agregrar Usuarios
    public void AgregarUsuario(string nombre, string contraseña)
    {
        Console.WriteLine("Ingrese su nombre de usuario: "+ nombre);
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su contraseña: "+ contraseña);
        contraseña = Console.ReadLine();
        
        if (usuario.ContainsKey(nombre))
        {
            Console.WriteLine("El usuario ya existe");
        }
        else
        {
            usuario.Add(nombre,contraseña);
            Console.WriteLine("Usuario registrado con exito");
        }
    }


        //Obtener Usuario
        public void ObtenerUsuario(string nombre)
        {
           string value = usuario.GetValueOrDefault(nombre, " usuario no encontrado");
           Console.WriteLine("Bienvenido: " + nombre);

        }



}

    


