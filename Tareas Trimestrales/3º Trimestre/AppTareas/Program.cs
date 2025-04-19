﻿class Program{

    public static void Main (string [] args)
    {

        Operaciones operaciones = new Operaciones ();

        Console.WriteLine("Bienvenido a tu gestor de tareas");
        
        
        while (true)
        {
            Console.WriteLine("Menú del programa");
            Console.WriteLine("1. Crear Tarea. ");
            Console.WriteLine("2. Buscar Tarea. ");
            Console.WriteLine("3. Eliminar Tarea. ");
            Console.WriteLine("4. Exportar Tareas. ");
            Console.WriteLine("5. Importar Tareas. ");
            Console.WriteLine("6. Salir.");                // Funciona
            Console.WriteLine("Que quieres hacer, elige una opción");

            int opcion = int.Parse(Console.ReadLine());

            if(opcion == 6)
            {
                Console.WriteLine("Saliendo de la app. Hasta pronto.");
                break;
            }

            if(opcion >= 1 && opcion <= 5)
            {
                // Mediante menu switch
                switch(opcion)
                {
                    // 1º Crear Tarea : Pedira -> nombre, descripcion, tipo y prioridad
                    case 1:

                    Console.WriteLine("Rellene los datos con su nombre, descripcion, tipo(persona, trabajo u ocio) y prioridad.\nA continuacion pulse enter y los datos se guardaran ");
                    operaciones.CrearTarea();
                    
                    break;

                    // 2º Buscar Tarea : Pedir -> tipo de tarea y  se mostrara todas las tareas
                    case 2:
                    operaciones.ObtenerInformacion(@"C:\Users\migue\Documents\GitHub\Fundamentos\Tareas Trimestrales\3º Trimestre\AppTareas\tareas.txt");
                    break;

                    // 3º Eliminar tarea : pedira -> un id, y se eliminara la tarea con el id indicado
                    case 3:
                    break;

                    // 4º Exportar tareas: se genera fichero llamado tareas.txt con inf de tdas las tareas,
                         // Cada fila mostrara -> ID, nombre, descripcion, tipo y prioridad
                    case 4:
                    operaciones.ExportarTarea(@"C:\Users\migue\Documents\GitHub\Fundamentos\Tareas Trimestrales\3º Trimestre\AppTareas\tareas.txt");
                    
                    break;
                    // 5º Importar tareas : Guardara en la lista que gestiona la app las tareas ubicadas en el fichero tareas.txt
                    case 5:
                    break;

                    case 6:
                    Console.WriteLine("Hasta pronto");
                    return;
                    
                   
                    
                }

            }else
            {
                Console.WriteLine("Opcion no valida, vuelve a elegir una opcion."); // Funciona 
            }
        }

          
    }
}