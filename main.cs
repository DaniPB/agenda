public class AgendaApplication
{
  static public void Main()
  {
    while(true) {
      string x = System.Console.ReadLine();
      if (x == "exit") {
        return;
      }
      System.Console.WriteLine(x);
    }
  } 
}
