class Program{

    public static void Main (string [] args){


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
                switch(opcion)
                {
                    case 1:
                    
                    break;

                    case 2:
                    break;

                    case 3:
                    break;

                    case 4:
                    break;

                    case 5:
                    break;

                    case 6:
                    break;
                }

            }else
            {
                Console.WriteLine("Opcion no valida, vuelve a elegir una opcion."); // Funciona 
            }
        }


// Mediante menu switch
    // 1º Crear Tarea : Pedira -> nombre, descripcion, tipo y prioridad

    // 2º Buscar Tarea : Pedir -> tipo de tarea y  se mostrara todas las tareas

    // 3º Eliminar tarea : pedira -> un id, y se eliminara la tarea con el id indicado

    // 4º Exportar tareas: se genera fichero llamado tareas.txt con inf de tdas las tareas,
                // Cada fila mostrara -> ID, nombre, descripcion, tipo y prioridad

    // 5º Importar tareas : Guardara en la lista que gestiona la app las tareas ubicadas en el fichero tareas.txt



      // ** Tareas consideraciones 
          // -> Id asignara automaticamente y sera unico para cada tarea 

          // -> El tipo tan solo podra ser alguno de los siguientes: persona, trabajo, ocio. Necesario utilizar Enum
          // Enum -> Clase con datos fijos. Objetos que ya estan cargados y solo puedo utilizar esos datos
              // jugador -> Constructor, Defensivo, Agresivo, Investigador -> Carpeta Utils

          // -> La prioridad sera un booleano 

    }
}