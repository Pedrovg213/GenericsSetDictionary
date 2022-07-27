namespace Prototype07 {
   internal class Program {
      static void Main( string[ ] args ) {

         string defautPath = @"C:\Users\pedro\Desktop\C# Estudo\Seção 15 - Generics, Set, Dictionary\GenericsSetDictionary\Prototype07\Prototype07\Files";

         using ( StreamWriter registryWriter = File.CreateText( defautPath + @"\Registry.csv" ) ) {

            Console.Write( "How many registry to do? " );
            int registrySize = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for ( int i = 1; i <= registrySize; i++ ) {

               Console.Write( $"Candidate's name #{i}: " );
               string name = Console.ReadLine();
               Console.Write( $"Candidate's votes #{i}: " );
               int votesNum = int.Parse(Console.ReadLine());
               Console.WriteLine();

               registryWriter.WriteLine( $"{name},{votesNum}" );

            }
         }

         Dictionary<string, int> votes = new Dictionary<string, int>();

         using ( StreamReader registryReader = File.OpenText( defautPath + @"\Registry.csv" ) ) {
            while ( !registryReader.EndOfStream ) {

               string[] infos = registryReader.ReadLine().Split(',');
               string name = infos[0];
               int votesNum = int.Parse(infos[1]);

               if ( votes.ContainsKey( name ) )
                  votes[ name ] += votesNum;
               else
                  votes[ name ] = votesNum;

            }
         }

         string key = "";
         string winner = "";
         Console.WriteLine( "Total Votes:" );
         foreach ( var infos in votes ) {

            Console.WriteLine( $"{infos.Key}: {infos.Value}" );

            if ( votes.ContainsKey( key ) && infos.Value > votes[ key ] )
               winner = infos.Key;

            key = infos.Key;
         }

         Console.WriteLine();
         Console.WriteLine( "WINNER: " + winner );
      }
   }
}