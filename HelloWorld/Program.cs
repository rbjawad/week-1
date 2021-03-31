using sc = System.Console;

namespace Revature.Week1.HelloWorld
{
  //class, struct, interface, enum only sopes available to the namespace

  class Program // class scope
  {
    private static void Main() //method scope
    {
      // stdin to get your name
      sc.WriteLine("enter your name:");
      // string in;
      var input = sc.ReadLine(); // datatype inference
      // object fred2 = System.Console.ReadLine(); //anonymous datatype
      //stdout to print your name
      sc.WriteLine($"Hello my name is {input}"); // string interpolation, template string
    }
    private void UiPath()
    {
      { // block scope
      }

      { // block scope
      }
    }
  }
}