using System.Collections.Generic;

public class Repl
{
  private Validator _validador;
  private Shell _shell;

  public Repl()
  {
    _validador = new Validator();
    _shell = new Shell();
  }

  public static void Listen() {
    System.Console.WriteLine("Ingresa comando");
    while(true) {
      string x = System.Console.ReadLine();
      if (x == "exit") {
        return;
      }
      System.Console.WriteLine(x);
    }
  }

  private void Separador() {
  }

  private void Repartidor() {
  }
}

public class Shell
{
  private Logger Log;

  public Shell()
  {
     Log = new Logger();
  }

  public void IngresarContacto(string nombre, string telefono, string correo)
  {
  }

  public List<Contacto> ListarContacto()
  {
    return new List<Contacto>();
  }

  public void IngresarTarea(string nombre)
  {
  }

  public List<Tarea> ListarTarea()
  {
    return new List<Tarea>();
  }

  public void IngresarReunion(string titulo, string fecha)
  {
  }

  public List<Reunion> ListarReunion()
  {
    return new List<Reunion>();
  }
}

public class Contacto
{
  public string Nombre { get; set; }
  public string Telefono { get; set; }
  public string Correo { get; set; }
}

public class Reunion
{
  public string Titulo { get; set; }
  public string Fecha { get; set; }
}

public class Tarea
{
  public string Description { get; set; }
}

public class Logger
{
  public void Write(string message)
  {
    System.Console.WriteLine("LOG: " + message);
  }
}

public class DB
{
  private List<Tarea> _tareas;
  private List<Reunion> _reuniones;
  private List<Contacto> _contactos;

  public bool Insert(string item)
  {
    return false;
  }

  public List<T> Select<T>(string command)
  {
    return new List<T>();
  }
}

public class Validator
{
  public bool IsValid(string command, string[] args)
  {
    return false;
  }
}

public class AgendaApplication
{
  static public void Main()
  {
    Repl.Listen();
  }
}
