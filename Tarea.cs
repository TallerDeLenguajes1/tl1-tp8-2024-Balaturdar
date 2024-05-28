// See https://aka.ms/new-console-template for more information
public class Tarea
{
    private int id;
    private string descripcion;
    private int duracion;

    public int Id { get => id;}
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }
    
    public Tarea(int id, string descripcion, int duracion)
    {
        this.id = id;
        this.descripcion = descripcion;
        this.duracion = duracion;
    }

    public string MostrarTarea(){
        return id + descripcion + duracion;
    }
}