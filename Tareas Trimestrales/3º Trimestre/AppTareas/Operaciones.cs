class Operaciones
{
    private List<Tarea> listaTareas;

    public  Operaciones()
    {
        listaTareas = new List<Tarea>();
        
    }

    public void CrearTarea()
    {
        Console.WriteLine("Nombre: ");
        string? nombre = Console.ReadLine();

        Console.WriteLine("Descripcion: ");
        string? descripcion = Console.ReadLine();

        Console.WriteLine("Tipo (persona, trabajo o ocio): ");
        Tipo tipo = Enum.Parse<Tipo>(Console.ReadLine().ToLower());

        Console.WriteLine("Prioridad: ");
        bool prioridad = bool.Parse(Console.ReadLine());

        Tarea tarea = new Tarea(nombre, descripcion, tipo, prioridad);
        listaTareas.Add(tarea);
        Console.WriteLine("Tarea creada.");

    }

    // Obtener la informacion 
    public void ObtenerInformacion(String path)
    {
        Console.WriteLine("Obteniendo fichero: "+path);
        if (!File.Exists(path))// Si no existe
        {
            File.Create(path); // creas
            Console.WriteLine("El fichero se a creado. ");
        }
        else
        {
            Console.WriteLine("El fichero ya existe.");
            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine("Last Access Time: "+ fileInfo.LastAccessTime);
            Console.WriteLine("Atributo: "+ fileInfo.Attributes);
            Console.WriteLine("Tamaño: "+ fileInfo.Length);
            Console.WriteLine("Tamaño: "+ fileInfo.Length); 
            Console.WriteLine("Nombre del fichero: "+ fileInfo.Name); 
            Console.WriteLine("Directorio: "+ fileInfo.DirectoryName);
        }
    }

    public void ExportarTarea(string path)
    {
        if(!File.Exists(path))
        {
            File.Create(path);
        }
        FileStream? fileStream = null;
        StreamWriter? streamWriter = null;

        try
        {
            fileStream = new FileStream(path, FileMode.Append);
            streamWriter = new StreamWriter(fileStream);

            foreach (var item in listaTareas)
            {
                streamWriter.WriteLine(item.ExportarDato());
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("La tarea no existe");
            Console.WriteLine(e.Message);
        }
        catch(IOException e)
        {
            Console.WriteLine("Error de entrada / salida");
            Console.WriteLine(e.Message);
        }
        finally
        {
            try
            {
                streamWriter?.Close();
                fileStream?.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error al cerrar el fichero: "+ e.Message);
            }
        }

            
    }
}