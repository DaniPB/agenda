using System.Collections.Generic;
using System.Linq;

public class Repl
{
  private Shell _shell;

  public Repl()
  {
    _shell = new Shell();
  }

  public static void Listen() {
    System.Console.WriteLine("Ingresa comando");
    while(true) {
      string x = System.Console.ReadLine();
      if (x == "exit") {
        return;
      }
      Repl repl = new Repl();
      Validator v = new Validator();
      var comandos = repl.Separador(x);
      (bool isValid, int diferencia) =  v.EntryValidator(comandos)

      if(isValid){
        repl.Repartidor(comandos);
      }

      System.Console.WriteLine(x);
    }
  }


  private Dictionary<string, string[]> Separador(string cadena) {
    /*Aqui se hace la lógica de separar el string*/
    return new Dictionary<string, string[]>();
  }

// estructura del hash {nombre_comando: [valores]}
  private void Repartidor(Dictionary<string, string[]> comandos) {
     string comando = comandos.Keys.ToArray()[0];
     string[] parametros = comandos.Values.ToArray()[0];
     switch(comando){
       case "new-contact":
          _shell.IngresarContacto(parametros[0], parametros[1], parametros[2]);
          break;
       case "list-contacts":
         _shell.ListarContacto();
         break;
       case "new-task":
          _shell.IngresarTarea(parametros[0]);
          break;
       case "list-tasks":
         _shell.ListarTarea();
         break;
       case "new-meeting":
          _shell.IngresarReunion(parametros[0], parametros[0]);
          break;
       case "list-meetings":
         _shell.ListarReunion();
         break;
     }
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
  public (bool, int) EntryValidator(Dictionary<string, string[]> command)
  {
    string comando = command.Keys.ToArray()[0];
    string[] parametros = command.Values.ToArray()[0];
    bool respuesta = false;
    int diferencia = 0;
     switch(comando){
       case "new-contact":
          diferencia = 3 - parametros.length;
          respuesta = parametros.length == 3;
          break;
       case "new-todo":
         diferencia = 1 - parametros.length;
         respuesta = parametros.length == 1;
         break;
       case "new-meeting":
         diferencia = 2 - parametros.length;
         respuesta = parametros.length == 2;
         break;
       case "list-meetings":
       case "list-todo":
       case "list-contacts":
         respuesta = parametros.length == 0;
         break;
       default:
         respuesta = false;
    }
    if(respuesta && diferencia == 0){
      return true
    }else{
      return false
    }
  }
}

public class AgendaApplication
{
  static public void Main()
  {
    Repl.Listen();
  }
}


// contacto
this.MissingParamsErrors(["Falta el nomber", "flata el telefono", "falta el email"])

var objCoctact = new Contact{}
System.Consnole.WiteLine(objConact.Errors)/// "Falta el nombre", "falta el telefono", "falta el email"

var objCoctact = new Contact{Nombre="juan"}
System.Consnole.WiteLine(objConact.Errors)/// "falta el telefono", "falta el email"

System.Consnole.WiteLine(objConact.Errors)/// "falta el email"

var objCoctact = new Contact{Nombre="juan", Telefono="3190", Email="ntoheu@oeu.com"}
System.Consnole.WiteLine(objConact.Errors)///
