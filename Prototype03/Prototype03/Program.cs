using Prototype03.Entities;

namespace Prototype03 {
   internal class Program {
      static void Main( string[ ] args ) {

         Client client01 = new Client("Maria", "maria@gmail.com");
         Client client02 = new Client("Alex", "maria@gmail.com");

         Console.WriteLine( client01.Equals( client02 ) );
         Console.WriteLine( client01 == client02 );
         Console.WriteLine( client01.GetHashCode() );
         Console.WriteLine( client02.GetHashCode() );

      }
   }
}