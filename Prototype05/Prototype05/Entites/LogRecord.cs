using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype05.Entites {
   internal class LogRecord {

      public string UserName {
         get; set;
      }
      public DateTime Instant {
         get; set;
      }


      public LogRecord( string _userName , DateTime _instant ) {

         UserName = _userName;
         Instant = _instant;

      }


      public override bool Equals( object? obj ) {

         if ( !( obj is LogRecord ) )
            return false;

         LogRecord logRecord = obj as LogRecord;

         return ( UserName.Equals( logRecord.UserName ) );

      }
      public override int GetHashCode( ) {
         return ( UserName.GetHashCode() );
      }
   }
}
