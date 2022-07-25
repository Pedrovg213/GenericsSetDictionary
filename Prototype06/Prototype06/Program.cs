using Prototype06.Entities;

namespace Prototype06 {
   internal class Program {
      static void Main( string[ ] args ) {

         // INPUTS
         // Course A
         Console.Write( "How many students for course A? " );

         int studentsNum = int.Parse(Console.ReadLine());
         HashSet<Student> studentsA = new HashSet<Student>();

         for ( int i = 0; i < studentsNum; i++ ) {

            Console.Write( "Enter student ID: " );
            studentsA.Add( new Student( int.Parse( Console.ReadLine() ) ) );

         }
         Console.WriteLine();

         // Course B
         Console.Write( "How many students for course B? " );

         studentsNum = int.Parse( Console.ReadLine() );
         HashSet<Student> studentsB = new HashSet<Student>();

         for ( int i = 0; i < studentsNum; i++ ) {

            Console.Write( "Enter student ID: " );
            studentsB.Add( new Student( int.Parse( Console.ReadLine() ) ) );

         }
         Console.WriteLine();

         // Course C
         Console.Write( "How many students for course C? " );

         studentsNum = int.Parse( Console.ReadLine() );
         HashSet<Student> studentsC = new HashSet<Student>();

         for ( int i = 0; i < studentsNum; i++ ) {

            Console.Write( "Enter student ID: " );
            studentsC.Add( new Student( int.Parse( Console.ReadLine() ) ) );

         }
         Console.WriteLine();

         // PROCESS
         HashSet<Student> totalStudents = new HashSet<Student>();
         totalStudents.UnionWith( studentsA );
         totalStudents.UnionWith( studentsB );
         totalStudents.UnionWith( studentsC );

         // OUTPUT
         Console.Write( "TOTAL STUDENTS: " + totalStudents.Count );

      }
   }
}