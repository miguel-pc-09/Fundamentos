// Clase base del resto de los elementos -> SUPERCLASE
using System.Reflection;

abstract class Enemigo
{
    public string nombre {get; set;}
    public  int vida {get; set;}
    public int poder {get; set;}


    public Enemigo(){}

    public Enemigo(string nombre, int vida, int poder)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.poder = poder;
    }
    public Enemigo(string nombre)
    {
        this.nombre = nombre;
        this.vida = 100;
        this.poder = 50;
    }
    public string GetNombre()
    {
        return this.nombre;
    }
    public void mostrarDatos()
    {
        Console.WriteLine("El nombre del enemigo: "+ nombre);
        Console.WriteLine("El nivel de vida del enemigo es: "+ vida);
        Console.WriteLine("El nivel de poder del enemigo  es: "+ poder);
    }
    public abstract void realizarAtaque();

   
}