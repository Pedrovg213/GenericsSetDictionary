
namespace Prototype04 {
   internal class Program {
      static void Main( string[ ] args ) {

         // HashSet
         Console.WriteLine( "HASHSET:" );
         HashSet<string> hash = new HashSet<string>();

         hash.Add( "TV" );
         hash.Add( "Notebook" );
         hash.Add( "Tablet" );

         Console.WriteLine( hash.Contains( "CPU" ) );
         Console.WriteLine( hash.Contains( "TV" ) );

         foreach ( string str in hash )
            Console.WriteLine( str );
         Console.WriteLine();

         // Test
         Console.WriteLine( "TEST:" );
         HashSet<Product> products = new HashSet<Product>();
         products.Add( new Product( "TV" , 900.00 ) );
         products.Add( new Product( "Notebook" , 1200.00 ) );

         Product prod = new Product("Notebook", 1200.00);
         Console.WriteLine( products.Contains( prod ) );

         HashSet<Point> points = new HashSet<Point>();
         points.Add( new Point( 3 , 4 ) );
         points.Add( new Point( 5 , 10 ) );

         Point point = new Point(5, 10);
         Console.WriteLine( points.Contains( point ) );

         Console.WriteLine();

         // SortedSet
         Console.WriteLine( "SORTEDSET:" );
         SortedSet<int> sorted01 = new SortedSet<int>{ 0, 2, 4, 5, 6, 8, 10};
         SortedSet<int> sorted02 = new SortedSet<int>{ 5, 6, 7, 8, 9, 10 };

         PrintCollection( sorted01 );

         // union
         SortedSet<int> sorted03 = new SortedSet<int>(sorted01);
         sorted03.UnionWith( sorted02 );
         PrintCollection( sorted03 );

         // intersection
         SortedSet<int> sorted04 = new SortedSet<int>(sorted01);
         sorted04.IntersectWith( sorted02 );
         PrintCollection( sorted04 );

         // difference
         SortedSet<int> sorted05 = new SortedSet<int>(sorted01);
         sorted05.ExceptWith( sorted02 );
         PrintCollection( sorted05 );

      }

      static void PrintCollection<T>( IEnumerable<T> collection ) {

         foreach ( T item in collection )
            Console.Write( item + " " );
         Console.WriteLine();

      }
   }
}