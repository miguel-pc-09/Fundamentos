// ** Tareas consideraciones 
// -> Id asignara automaticamente y sera unico para cada tarea
using System.Diagnostics.Contracts;
using System.Dynamic;

class Tarea
{
    private static int contador = 1; // lo marcamos como 1 y apartir de aqui le indicamos que sea sumatorio en el constructor
    public int identificador {get; private set;}
    public Tipo tipo {get; set;}
    public string? nombre {get; set;}
    public string? descripcion {get; set;}
    public bool prioridad {get; set;}


    // Constructor vacio
    public Tarea (){}

    // Constructor con todo
    public Tarea(string nombre, string descripcion, Tipo tipo, bool prioridad)
    {
        identificador = contador++;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.tipo = tipo;
        this.prioridad = prioridad;
    }

    public string ExportarDato()
    {
        return identificador + "," + nombre + "," + descripcion + "," + tipo + "," + prioridad;
    }

    
}