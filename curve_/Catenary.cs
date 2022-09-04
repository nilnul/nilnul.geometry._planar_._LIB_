using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_
{
	/// <summary>
	/// In physics and geometry, a catenary (US: /ˈkætənɛri/, UK: /kəˈtiːnəri/) is the curve that an idealized hanging chain or cable assumes under its own weight when supported only at its ends in a uniform gravitational field.
	/// </summary>
	public class Catenary4dbl
		:
		nilnul.obj.Box1<nilnul.num.real_.NonnilDblI>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">
		///
		/// </param>
		public Catenary4dbl(NonnilDblI val) : base(val)
		{
		}
		public Catenary4dbl(NonnilDbl val) : this((NonnilDblI) val)
		{
		}

		public Catenary4dbl(double val) : this(new nilnul.num.real_.NonnilDbl(val) )
		{
		}


		public double vertical(double x) {
			var boxedAsDbl = boxed.dblee.ee;
			return boxedAsDbl *
				Math.Cosh(x / boxedAsDbl)
			;
		}

		/// <summary>
		/// when horizon coord changes from the lowest point to a positive number, the length of the chain is calculated as follows.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public double _lengthOfChainFroMinToNonnegHorizon(double x) {
			var boxedAsDbl = boxed.dblee.ee;
			return boxedAsDbl *
				Math.Sinh(x / boxedAsDbl)
			;
		}


	}
}
