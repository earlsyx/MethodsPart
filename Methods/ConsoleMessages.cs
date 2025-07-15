 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//creats vasic svtracuter of the class.
//static, allows to make a call directly to the methods
//without having to set thigns up first called instantitation.
namespace Methods
{
 //public- not for permission, not for security
 //-any body can use this.
 // internal - any body that's in the project can use it.
 //private- anyone inside of this scope can use it but no body else.
 // can sound for security but not.
 // purpose, not allow people to call thing they shoud not really call directly.
    public static class ConsoleMessages
    {
       //create a method
       // void is return value, void nothing, return nothing
       // -send back from method
       //Pascal method, name of method
       //(), here dat you want to pass in.
       // {} scope
       public static void SayHi(string firstName) //method signature
        {
            //called parameter because we are sending it through the method
            Console.WriteLine($"Hello {firstName}!");
        }

        public static void SayGoodBye()
        {
            Console.WriteLine("Goodbye, user.");
            Console.WriteLine("Thank you for visiting.");
            Console.WriteLine("I cannot wait to see you again.");
        }
    }
}
