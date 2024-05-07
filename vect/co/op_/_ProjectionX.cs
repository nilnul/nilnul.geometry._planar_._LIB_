//using nilnul.geometry.planar._bloc;
using nilnul.geometry.planar.vect_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.co.op_
{
	/// <summary>
	/// decompose one vect in orthic pair of components. This is equivalent to a morph into a new orthic coordinate system and scale it also:
	///		:one component is along the other vect,
	///			, the length of which is the inner product of the two.
	///		:the other is orthic to the first component
	///	,as the result,
	///		: the sum of the componens is the vect times the length of the basis.
	/// </summary>
	/// <see cref="vect.to_.co_.decompose_.ortho_"/>
	/// vs:
	///		<see cref="vect.to_.co_.decompose_.ortho_._NormalX"/>
	static public class _ProjectionX
	{

		public static (Complex lengthwise, Complex torque) _Op_0nonnil(Vect4dblI basis, Vect4dblI x)
		{
			return _Op_0nonnil(
				geometry.planar.vect._ToX.ToComplex(basis)
				,
				geometry.planar.vect._ToX.ToComplex(x)
			);
		}




		/// <summary>
		/// 
		/// </summary>
		/// <param name="basis"></param>
		/// <param name="x"></param>
		/// <returns>
		/// such that:
		///		align + orthic = x *basis.Magnitude
		/// </returns>
		public static (Complex lengthwise ,Complex torque) _Op_0nonnil(Complex basis, Complex x)
		{

			/// the canonical deomposition would be:
			///		the inner product / basis.Norm
			///	but here we don't divide the basis.Norm. That is, multply the above by basis.Norm,resulting:
			///		,the length of the longitude vect.
			/// 
			var longitude = planar.vect.co.scala_._DotProductX.Dbl(basis, x);
			Complex align = longitude * basis/basis.Magnitude;

			var orthic = x * basis.Magnitude - align;

			return ( align ,orthic);  // align + orthic = x *basis.Magnitude


		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="basis"></param>
		/// <param name="x"></param>
		/// <returns>
		///
		/// </returns>
		public static (Complex lengthwise,Complex torque) _Op_0norm(Complex basis, Complex x)
		{

			/// the canonical deomposition would be:
			///		the inner product / basis.Norm
			///	but here we don't divide the basis.Norm. That is, multply the above by basis.Norm,resulting:
			///		,the length of the longitude vect.
			///
			/// the parallel or aligned, lengthwise, longwise, linear force.
			var longitude = planar.vect.co.scala_._DotProductX.Dbl(basis, x);

			Complex align = longitude * basis;

			///torque
			var orthic = x  - align;

			return (align  , orthic);


		}

	}
}
