
namespace Prototype06.Entities {
   internal class Student {

      public int Id {
         get; set;
      }


      public Student( int _id ) {

         Id = _id;

      }


      public override bool Equals( object? obj ) {

         if ( !( obj is Student ) )
            return ( false );

         Student other = (Student)obj;

         return ( Id.Equals( other.Id ) );

      }
      public override int GetHashCode( ) {

         return ( Id.GetHashCode() );

      }
   }
}
