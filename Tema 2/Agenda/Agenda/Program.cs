public class MyClass
{
    public static void Main(string[] args)
    {
        // Con esto ya se a creado la agenda Y con los que ya estaban creados por defecto 
        Agenda agenda = new Agenda();
        //[{B},{M},{J}]

        agenda.AgregarPersona("001D", "Marcos");
        // Ahora dentro estaran [{B},{M},{J},{M}]

        // Si ejecutamos esto mismo dni pero distinto nombre
        agenda.AgregarPersona("001E", "Beatriz");
        // Saldra un error, porque la clave esta repetida

        agenda.ObtenerPersona("001A");
    }
}