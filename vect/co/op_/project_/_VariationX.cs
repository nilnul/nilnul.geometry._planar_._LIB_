//using nilnul.geometry.planar._bloc;
using nilnul.geometry.planar.vect_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.co.op_.project_
{
	/// <summary>
	/// like a big ball smashing a little ball, splitting it into two orthic directions.
	/// in comparison with <see cref="_VariationX"/>, here we avoid division by the basis.Magnitude.
	/// </summary>
	/// <see cref="vect.to_.co_.decompose_.ortho_"/>
	static public class _VariationX
	{

		public static (Complex lengthwise, Complex torque) Op(Vect4dblI basis, Vect4dblI x)
		{
			return Op(
				geometry.planar.vect._ToX.ToComplex(basis)
				,
				geometry.planar.vect._ToX.ToComplex(x)
			);
		}

		public static (Complex lengthwise ,Complex torque) Op(Complex basis, Complex x)
		{

			/// the canonical deomposition would be:
			///		the inner product / basis.Norm
			///	but here we don't divide the basis.Norm. That is, multply the above by basis.Norm,resulting:
			///		,the length of the longitude vect.
			/// 
			var longitude = planar.vect.co.scala_._DotProductX.Dbl(basis, x);
			Complex align = longitude * basis;

			var orthic =  x * basis.Magnitude *basis.Magnitude- align  ;

			return ( align ,orthic);  // align + orthic = x *basis.Variance


		}



	}
}
