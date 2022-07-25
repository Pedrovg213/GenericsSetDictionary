
namespace Prototype04 {
   internal class Product {

      public string Name {
         get; set;
      }
      public double Price {
         get; set;
      }


      public Product( string _name , double _price ) {

         Name = _name;
         Price = _price;

      }


      public override bool Equals( object? obj ) {

         if ( !( obj is Product ) )
            return ( false );

         Product other = obj as Product;

         return (
            Name.Equals( other.Name ) && Price.Equals( other.Price ) );

      }
      public override int GetHashCode( ) {

         return ( Name.GetHashCode() + Price.GetHashCode() );

      }
   }
}
