// ** Tareas consideraciones 
          // -> Id asignara automaticamente y sera unico para cada tarea
public class Tarea
{
    public Tipo tipo {get; set;}
    public string? nombre {get; set;}
    public string? descripcion {get; set;}
    public bool prioridad {get; set;}


    // Constructor vacio
    public Tarea (){}

    // Constructor con todo
    public Tarea(string nombre, string descripcion, Tipo tipo, bool prioridad)
    {
        this.nombre=nombre;
        this.descripcion=descripcion;
        this.tipo=tipo;
        this.prioridad=prioridad;
    }

    public string ExportarDato()
    {
        return nombre + "," + descripcion + "," + tipo + "," + prioridad;
    }

    
}