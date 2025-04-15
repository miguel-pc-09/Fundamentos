class Program{

    public static void Main(string[] args){
        Console.WriteLine("Trabajo con ficheros");
        // llamamos a operaciones para llamar a obtener informacion 
        Operaciones operaciones = new Operaciones();
        // Dentro () meteremos el path del fichero que antes cogimos Al ser Windows utilizar un @ y despues "path"
        operaciones.Obtenerinfirmacion(@"C:\Users\migue\Documents\GitHub\Fundamentos\Tema 4\Ficheros\informacion.txt");
        //2º Vamos a Operaciones a crear el obtener informacion con el console
        // 4º Ejecutamos el Last...
    }
}