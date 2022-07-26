﻿using System.Globalization;
using Prototype02.Entities;
using Prototype02.Services;

namespace Prototype02 {
   internal class Program {
      static void Main( string[ ] args ) {

         List<Products> list = new List<Products>();

         Console.Write( "Enter N: " );
         int n = int.Parse(Console.ReadLine());
         Console.WriteLine();

         for ( int i = 0; i < n; i++ ) {

            string [] vect = Console.ReadLine().Split(',');
            string name = vect[0];
            double price = double.Parse(vect[1], CultureInfo.InvariantCulture);

            list.Add( new Products( name , price ) );

         }

         CalculationService calculationService = new CalculationService();
         Products max = calculationService.Max(list);

         Console.WriteLine( "Max:" );
         Console.WriteLine( max );

      }
   }
}