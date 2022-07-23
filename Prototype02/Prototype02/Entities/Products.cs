using System;
using System.Globalization;

namespace Prototype02.Entities {
   internal class Products : IComparable {

      public string Name {
         get; set;
      }
      public double Price {
         get; set;
      }


      public Products( string _name , double _price ) {

         Name = _name;
         Price = _price;

      }



      public int CompareTo( object? obj ) {

         if ( !( obj is Products ) )
            throw new ArgumentException( "Comparing erro: argument is not a product" );

         Products other = obj as Products;
         return Price.CompareTo( other.Price );

      }
      public override string ToString( ) {

         return ( Name + ", " + Price.ToString( "F2" , CultureInfo.InvariantCulture ) );

      }
   }
}
