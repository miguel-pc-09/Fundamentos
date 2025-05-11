using System.Collections;

public class Jugador
{
    // Atributos
    private string? nombre; // Si no le pongo ?, obligado a tener valor 
    private string? poderEspecial;
    private int nivelAtaque, nivelDefensa, nivelVida;

    // Conjunto de habilidades
    public List<Habilidad> listaHabilidades;

    // constructores -> 1- por defecto -> nunca tienen retorno -> porque retorna el objeto creado
    public Jugador(){}
    public Jugador(string nombre)
    {
        this.nombre = nombre;
        this.nivelVida = 100;
        this.listaHabilidades = new List<Habilidad>();
    }

    public Jugador(string nombre, string poder)
    {
        this.nombre = nombre;
        this.poderEspecial = poder; // aqui el this lo pone mas claro -> se refiere al de arriba
        this.nivelVida = 100;
        this.listaHabilidades = new List<Habilidad>();
    }

    public Jugador(string nombre, int nivelAtaque, int nivelDefensa)
    {
        this.nombre = nombre;
        this.nivelDefensa = nivelDefensa;
        this.nivelAtaque = nivelAtaque; 
        this.nivelVida = 100;
        this.listaHabilidades = new List<Habilidad>(); // 0 habilidades pero inicializada esperandolas
    }

    public Jugador(string nombre, int nivelAtaque, int nivelDefensa, List<Habilidad> lista)
    {
        this.listaHabilidades = lista;
        this.nombre = nombre;
        this.nivelDefensa = nivelDefensa;
        this.nivelAtaque = nivelAtaque; 
        this.nivelVida = 100;
         // 0 habilidades pero inicializada esperandolas
    }
    // Metodo atacar
    public void Atacar(Jugador jugador)
    {
        if(this.nivelAtaque> jugador.GetAtaque())
        {
            Console.WriteLine("soy el campeon");
            this.listaHabilidades.AddRange(jugador.GetListaHabilidades());
            jugador.GetListaHabilidades().Clear();
        }
        else 
        {
            Console.WriteLine("Me han dado una paliza");
            jugador.GetListaHabilidades().AddRange(this.listaHabilidades);
            this.listaHabilidades.Clear();
        }
    }


    // metodos
    public void AdquirirHabilidad(Habilidad habilidad)
    {
        this.listaHabilidades.Add(habilidad);
    }
    public void PerderHabilidades()
    {
        this.listaHabilidades.Clear();
    }

    public void ListarActividades()
    {
        foreach (var item in listaHabilidades)
        {
            Console.WriteLine(item.GetNombre());
            Console.WriteLine(item.GetPotenciador());
            Console.WriteLine(item.GetVida());
        }
    }


    // Setter -> metodo que establece, cambia, modifica un dato
    public List<Habilidad> GetListaHabilidades()
    {
        return this.listaHabilidades;
    }
    public void SetPoder(string poder)
    {
        this.poderEspecial = poder;
    }
    public string GetPoder()
    {
        return this.poderEspecial;
    }

    public void SetDefensa(int defensa)
    {
        this.nivelDefensa = defensa;
    }
    public int GetAtaque()
    {
        return this.nivelAtaque;
    }
    public void SetAtaque(int ataque)
    {
        this.nivelAtaque = ataque;
    }
}