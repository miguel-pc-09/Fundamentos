using System.Collections;

public class Jugador
{
    // Atributos
    private string? nombre; // Si no le pongo ?, obligado a tener valor 
    private string? poderEspecial;
    private int nivelAtaque, nivelDefensa, nivelVida;

    // Conjunto de habilidades
    private ArrayList listaHabilidades;

    // constructores -> 1- por defecto -> nunca tienen retorno -> porque retorna el objeto creado
    public Jugador(){}
    public Jugador(string nombre)
    {
        this.nombre = nombre;
        this.nivelVida = 100;
    }

    public Jugador(string nombre, string poder)
    {
        this.nombre = nombre;
        this.poderEspecial = poder; // aqui el this lo pone mas claro -> se refiere al de arriba
        this.nivelVida = 100;
    }

    public Jugador(string nombre, int nivelAtaque, int nivelDefensa)
    {
        this.nombre = nombre;
        this.nivelDefensa = nivelDefensa;
        this.nivelAtaque = nivelAtaque; 
        this.nivelVida = 100;
        this.listaHabilidades = new ArrayList(); // 0 habilidades pero inicializada esperandolas
    }

    public Jugador(string nombre, int nivelAtaque, int nivelDefensa, ArrayList lista)
    {
        this.listaHabilidades = lista;
        this.nombre = nombre;
        this.nivelDefensa = nivelDefensa;
        this.nivelAtaque = nivelAtaque; 
        this.nivelVida = 100;
        this.listaHabilidades = new ArrayList(); // 0 habilidades pero inicializada esperandolas
    }


    // metodos


    // Setter -> metodo que establece, cambia, modifica un dato
    public void setPoder(string poder)
    {
        this.poderEspecial = poder;
    }
    public string getPoder()
    {
        return this.poderEspecial;
    }

    public void setDefensa(int defensa)
    {
        this.nivelDefensa = defensa;
    }
    public int getAtaque()
    {
        return this.nivelAtaque;
    }
    public void setAtaque(int ataque)
    {
        this.nivelAtaque = ataque;
    }
}