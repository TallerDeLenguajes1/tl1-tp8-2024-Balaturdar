// See https://aka.ms/new-console-template for more information


int opc, idBuscado;
Random aleatorio = new();
bool aux = true;
string[] descripciones = {"tarea 1", "tarea 2", "tarea 3", "tarea 4"};
var TareasPendientes = new List<Tarea>();
var TareasRealizadas = new List<Tarea>();

do
{
    Console.WriteLine("\n\n**************************************************");
    Console.WriteLine("**        1-inicializar tareas pendiente        **");
    Console.WriteLine("**    2-listar tareas pendientes y realizadas   **");
    Console.WriteLine("** 3-transferir tareaa de pendiente a realizada **");
    Console.WriteLine("**           4-buscar tarea por ID              **");
    Console.WriteLine("**       5-buscar tarea por palabra clave       **");
    Console.WriteLine("**                    6-salir                   **");
    Console.WriteLine("**************************************************");
    Console.WriteLine("\nIngrese una opcion: ");
    do{
        aux = int.TryParse(Console.ReadLine() ,out opc);
        if(!aux){
            Console.WriteLine("debe ingresar un numero para seleccionar una opcion");
        }
    }while (!aux);


    switch (opc)
    {
        case 1://icializar tareas pendiente 
            int CantTareas=aleatorio.Next(100);
            for (int i = 0; i > CantTareas ; i++){
                int Idescripcion = aleatorio.Next(descripciones.Length);
                int RDuracion = aleatorio.Next(100);
                TareasPendientes.Add(new Tarea(i,descripciones[Idescripcion],RDuracion));
            }
            Console.WriteLine("Se ha generado la lista de tareas pendientes");
            break;
        case 2://listar tareas
            if(TareasPendientes == null){
                Console.WriteLine("\nNo hay tareas en la lista de pendientes");
            }else{
                foreach (var tareas in TareasPendientes)
                {
                    
                }
            }
            if(TareasRealizadas == null){
                Console.WriteLine("\nNo hay tareas en la lista de realizados");
            }else{
                foreach (var tareas in TareasRealizadas)
                {
                    
                }
            }
            
            break;
        case 3://pasar tarea
            if(TareasPendientes == null){
                Console.WriteLine("\nNo hay tareas en la lista de pendientes");
                break;
            }
            Console.WriteLine("\n Ingrese el ID de la tarea que se completo: ");
            do{
                aux = int.TryParse(Console.ReadLine() ,out idBuscado);
                if(aux){
                    Console.WriteLine("debe ingresar un numero para seleccionar una opcion");
                }
            }while (!aux);

            foreach (var tarea in TareasPendientes){
                if(idBuscado == tarea.Id){
                    TareasRealizadas.Add(tarea);
                    TareasPendientes.Remove(tarea);
                    break;
                }
            }
            break;
        case 4://buscar tareaid
            break;
        case 5://buscar tarea descripcion
            break;
        default:
            break;
    }



} while (opc != 6);


