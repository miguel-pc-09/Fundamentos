using System.Security.Cryptography.X509Certificates;

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
        /*FileInfo fileInfo = new FileInfo(path);
        Console.WriteLine("Last Access Time: "+ fileInfo.LastAccessTime); // Esto ya es un metodo normal y corriente. Tendremos lo mismo pero en vez de pertenecer a la clase,
        Console.WriteLine("Atributo: "+ fileInfo.Attributes); // pertenece al objeto.
        Console.WriteLine("Tamaño: "+ fileInfo.Length); 
        Console.WriteLine("Nombre del fichero: "+ fileInfo.Name); 
        Console.WriteLine("Directorio: "+ fileInfo.DirectoryName); 
        Console.WriteLine("Exist: "+ fileInfo.Exists);*/

        // Visto todo esto podemos hacer varias cosas 

        // 8º Sin la necesidad de crear ese fileinfo ahora desde el file.
        // Como devuelve un boolean podemos hacer -> IF por ejemplo
        if(!File.Exists(path)){ // Si no existe 
            File.Create(path); // me das el path
            Console.WriteLine("El fichero se ha creado");
        }
        else // En caso contrario podemos acceder al contenido de el mismo. Copiamos el anterior
        { 
            Console.WriteLine("El fichero ya existe");
            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine("Last Access Time: "+ fileInfo.LastAccessTime);
            Console.WriteLine("Atributo: "+ fileInfo.Attributes);
            Console.WriteLine("Tamaño: "+ fileInfo.Length);
            Console.WriteLine("Tamaño: "+ fileInfo.Length); 
            Console.WriteLine("Nombre del fichero: "+ fileInfo.Name); 
            Console.WriteLine("Directorio: "+ fileInfo.DirectoryName); 
            // Ahora en el paso 9º en program vamos a cambiar la ruta 
        }
        // Ahora si nos fijamos desde el file podemos hacer muchas cosas
        // podemos hacer la escritura directamente, podemos el anexado,copiarlo, obtener todos los byte que pertenecen al elemento correspondiente lo que queramos file.
        // Es recomendable hasta cierto pùnto solo hace lo que pide el metodo
        // Si queremos algo mas personalizado necesitaremos los FLUJOS DE DATOS DE ESCRITURA Y LECTURA
    }
        // 10º crearemos los metodos
       public void EscribirFichero(String path){
        // Queremos ahcer una escritura manual
           FileStream fileStream = new FileStream(path, FileMode.Append); // En modo Appen quiere decir lo mismo file.appendtext. Puesto modo escritura y APPEND si no lo ponemos lo pisa
           //fileStream.Write(123); // Se lo tenemos que decir en modo byte. Quitamos el fileStream y lo pasamos a StreamWriter
           StreamWriter streamWriter = new StreamWriter(fileStream);// Ahora para poder hacer la escritura
           streamWriter.WriteLine("hola");
           streamWriter.Write(123);
           // IMPORTANTE: Siempre cierro el flujo de la informacion streamWriter.Close();
           streamWriter.Close();
           // El cierre del flujo del filestream no es necesario, pero se puede poner
           fileStream.Close();
           // Ahora en el paso 11 iremos a program a ejecutar este metodo para escribir
           
       } 



}