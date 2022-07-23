using System;

namespace Prototype03.Entities {
   internal class Client {

      public string Name {
         get; set;
      }
      public string Email {
         get; set;
      }


      public Client( string _name , string _email ) {
      
         Name = _name;
         Email = _email;

      }


      public override bool Equals( object? obj ) {

         return (( obj as Client ).Email.Equals( Email ));

      }
      public override int GetHashCode( ) {

         return ( Email.GetHashCode() );

      }
   }
}
