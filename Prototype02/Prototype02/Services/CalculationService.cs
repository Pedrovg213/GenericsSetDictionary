
namespace Prototype02.Services {
   internal class CalculationService {

      public T Max<T>( List<T> _list ) where T : IComparable {

         if ( _list.Count == 0 )
            throw new ArgumentException( "The list can not be empty." );

         T max = _list[0];

         for ( int i = 1; i < _list.Count; i++ )
            if ( _list[ i ].CompareTo( max ) > 0 )
               max = _list[ i ];

         return ( max );
      }
   }
}
