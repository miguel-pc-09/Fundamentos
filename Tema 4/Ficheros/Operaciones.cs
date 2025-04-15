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
        Console.WriteLine("Last Access Time: "+ File.GetLastAccessTime(path)); // Al ejecutar nos dira Last... y la fecha y hora en el momento de la ejecucion
        
        // 5º Atributos de la clase file
        Console.WriteLine("Atributos: "+ File.GetAttributes(path));// Devolvera un normal 

        // 6º Preguntar si existe
        Console.WriteLine("Exists: "+ File.Exists(path));
    }

}