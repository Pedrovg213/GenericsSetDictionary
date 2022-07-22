namespace Prototype01 {
   internal class Program {
      static void Main( string[ ] args ) {

         PrintService<int> service = new PrintService<int>();

         //inputs
         Console.Write( "How many values? " );
         int valuesRage = int.Parse(Console.ReadLine());

         for ( int i = 0; i < valuesRage; i++ ) {

            int value = int.Parse(Console.ReadLine());

            service.AddValue( value );

         }

         service.Print();
         Console.WriteLine( "First: " + service.First() );

      }
   }
}