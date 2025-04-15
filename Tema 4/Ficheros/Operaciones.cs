class Operaciones
{
    // Metodo para obtener informacion de un fichero
    public void Obtenerinfirmacion(String path)
    {
        //1º Cogeremos la ruta del fichero con boton derecho copy path(copiar ruta del fichero)
        //2º
        Console.WriteLine("Leyendo el fichero "+ path);

        //3º Creacion del file para ver diferencia con el de Java
        //File.GetLastAccessTime(path); // File es una clase estatica, conjunto de metodos estatico y como tal podemos poner File.(elegir)

        // Lo sacaremos por consola con Console.WriteLine
     //    Console.WriteLine("Last Access Time: "+ File.GetLastAccessTime(path)); // Al ejecutar nos dira Last... y la fecha y hora en el momento de la ejecucion
        
        // 5º Atributos de la clase file
     //  Console.WriteLine("Atributos: "+ File.GetAttributes(path));// Devolvera un normal 

        // 6º Preguntar si existe
     // Console.WriteLine("Existe: "+ File.Exists(path)); // Devolvera un True o False 

        // Los metodos Los metodos Exits, GetLastAccessTime, GetAttributes, pertenece a la case. Un elemento que es estatico no necesita del objeto de tipo file
        // para ejecutar el metodo correspondiente.  

        // 7º Ahora decimos que queremos guardar o acceder a un objeto de tipo de file. Anteriormente accedi de forma directa, pero a veces lo queremos guardar en variables
        // , lo queremos persistir, o llevar a una variable de entorno, lo que se nos ocurra.
        FileInfo fileInfo = new FileInfo(path);
        Console.WriteLine("Last Access Time: "+ fileInfo.LastAccessTime); // Esto ya es un metodo normal y corriente. Tendremos lo mismo pero en vez de pertenecer a la clase,
        Console.WriteLine("Atributo: "+ fileInfo.Attributes); // pertenece al objeto.
        Console.WriteLine("Tamaño: "+ fileInfo.Length); 
        Console.WriteLine("Nombre del fichero: "+ fileInfo.Name); 
        Console.WriteLine("Directorio: "+ fileInfo.DirectoryName); 
        Console.WriteLine("Exist: "+ fileInfo.Exists);

    }

}