public class Tarea
{
    private Tipo tipo;
    private string? nombre;
    private string? descripcion;
    private boolean prioridad;

    // Crear una List<>?
    public List<Tarea> listaTarea;

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
}