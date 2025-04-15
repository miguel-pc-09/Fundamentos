class Program{

    public static void Main(string[] args){
        Console.WriteLine("Trabajo con ficheros");
        // llamamos a operaciones para llamar a obtener informacion 
        Operaciones operaciones = new Operaciones();
        // Dentro () meteremos el path del fichero que antes cogimos Al ser Windows utilizar un @ y despues "path"
     //   operaciones.Obtenerinfirmacion(@"C:\Users\migue\Documents\GitHub\Fundamentos\Tema 4\Ficheros\informacion.txt");
        //2º Vamos a Operaciones a crear el obtener informacion con el console
        // 4º Ejecutamos el Last...

        // 9º Vamos a cambiarle la ruta en vez de informacion.txt sera escritura.txt
    //    operaciones.Obtenerinfirmacion(@"C:\Users\migue\Documents\GitHub\Fundamentos\Tema 4\Ficheros\escritura.txt");
        // Al no existir nos creara el fichero que podemos ver a la izquierda. 

        //11º Escribir en el fichero 
        operaciones.EscribirFichero(@"C:\Users\migue\Documents\GitHub\Fundamentos\Tema 4\Ficheros\escritura.txt");
        // La primera vez escribira lo que esta puesto, si ejecutamos una segunda vez escribira otra vez si sobreescribir
    }
}