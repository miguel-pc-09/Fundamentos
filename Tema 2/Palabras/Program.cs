public class Palabras 
{
    public static void Main(string[] args)
    {
        //string[] palabras = new string[10];
        //Console.WriteLine(palabras[8]); // posicion de lo q quiero
        string[] palabras = new string[]{"hola", "Adios", "que", "tal"};
        //string[][] palabrasMulti = new string[]{"hola", "Adios", "que", "tal"};
        // [null, null, null, null, null, null, null, null, null, null, null]
        Console.WriteLine(palabras[palabras.Length - 1]); // para coger la ultima palabra

        char[] abecedario = new char[]{'a', 'b', 'c', 'd', 'e'};
        // Scamos un random y lo saque por consola

        //int random = new Random().Next(1, 9);
        //Console.WriteLine(random);
        

        // obtener palabra generada que sea de 5 letras aleatorias del abecedario
        string palabraGenerada = "";

        // Con el for 
        for (int i = 0; i < 5; i++)
        {
            int random = new Random().Next(0, abecedario.Length-1);
            // es un char en abecedario random?
            char letra = abecedario[random];
            palabraGenerada += letra;
        }

        
        Console.WriteLine(palabraGenerada);
    }
}