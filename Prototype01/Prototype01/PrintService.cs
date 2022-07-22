
namespace Prototype01 {
   internal class PrintService<T> {

      private T[ ] Values = new T[10];
      private int Count = 0;


      public void AddValue( T _value ) {

         if ( Count == 10 )
            throw new InvalidOperationException( "PrintService is full." );

         Values[ Count ] = _value;
         Count++;

      }
      public T First( ) {

         if ( Count == 0 )
            throw new InvalidOperationException( "PrintService is empty." );

         return ( Values[ 0 ] );

      }
      public void Print( ) {

         Console.Write( "[" );
         for ( int i = 0; i < Count - 1; i++ )
            Console.Write( Values[ i ] + ", " );
         if ( Count > 0 )
            Console.Write( Values[ Count - 1 ] );
         Console.WriteLine( "]" );

      }
   }
}
