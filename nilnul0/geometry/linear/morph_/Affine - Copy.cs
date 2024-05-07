using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.morph_
{
	/// <summary>
	/// x A, where A is the matrix.
	/// p * scale + shift.
	/// </summary>
	/// <remarks>
	/// scale first, then shift
	///
	/// </remarks>
	/// <seealso cref="nilnul.geometry.linear.grad_.nontrivia.map_.TgtGrad4Dbl"/>
	public interface IAffine
		: IMorph

	{
	}

	public class Affine4dbl
		:
		nilnul.num.real.matrix_.square_.Secondary4dbl
		,
		nilnul.num.real.Op4dblI
		,
		nilnul.num.real.op_.Unary4dblI

	{


		public Affine4dbl(double scale, double shift) : base(
			(scale, 0)
			,
			(shift, 1)
		)
		{
		}


		public double scale { get { return base.ee[0, 0]; } }
		public double shift { get { return base.ee[1, 0]; } }

		public double op(double coord)
		{
			return nilnul.num.real.matrix.co_.multible._MultiX._Multiply_assumeSociable(
				new[] { coord, 1 }
				,
				this.boxed
			).First();
		}

		static public Affine4dbl OfSkid2grad(
			linear.grad_.nontrivia.map_.TgtGrad4Dbl skid2grad
		) {

			return new Affine4dbl(
				skid2grad.scale
				,
				skid2grad.shift
			);
		}

		public static Affine4dbl OfSkid2grad(double x1, double ee1, double x2, double ee2)
		{
			return OfSkid2grad(
				new grad_.nontrivia.map_.TgtGrad4Dbl(
					x1,ee1,x2,ee2
				)
			);
		}
		public static Affine4dbl OfShafts(double x1, double shift, double x2, double shiftOther)
		{

			return OfSkid2grad(
				x1,x1+shift
				,
				x2,x2+shiftOther
			);
		}


	}
}
