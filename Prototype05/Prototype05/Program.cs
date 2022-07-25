using Prototype05.Entites;

namespace Prototype05 {
   internal class Program {
      static void Main( string[ ] args ) {

         HashSet<LogRecord> records = new HashSet<LogRecord>();

         string defaultFilesPath = @"C:\Users\pedro\Desktop\C# Estudo\Seção 15 - Generics, Set, Dictionary\GenericsSetDictionary\Prototype05\Files";

         try {
            using ( StreamReader streamReader = File.OpenText( defaultFilesPath + @"\Datas.txt" ) ) {
               while ( !streamReader.EndOfStream ) {

                  string[] line = streamReader.ReadLine().Split(' ');
                  string name = line[0];
                  DateTime instant = DateTime.Parse(line[1]);

                  records.Add( new LogRecord( name , instant ) );

               }

               Console.WriteLine( "Total users: " + records.Count );

            }
         } catch ( IOException ioe ) {

            Console.WriteLine( "An error occurred." );
            Console.WriteLine( ioe.Message );

         }
      }
   }
}