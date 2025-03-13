using nilnul.num;
using nilnul.num.real_.nonneg_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;


namespace nilnul.geometry.planar.rotation_
{
	/// <summary>
	/// a rotation in [0,tau)
	/// </summary>
	public class DirectionDbl : planar.rotation_.nonneg_.LtTauOfDbl
	{
		public DirectionDbl(num.real_.nonneg_.LtTauOfDouble val) : base(val)
		{
		}

		public DirectionDbl(double real) : this(new LtTauOfDouble(real))
		{
		}




		static public DirectionDbl Create_byCannonize(double r)
		{
			return new DirectionDbl(
				nilnul.num.real_.floored._TailX.Doub(r / nilnul.num.real_.TauX.IntoDouble) * nilnul.num.real_.TauX.IntoDouble
			);
		}

		static public double _OfRotation(double r)
		{
			return nilnul.num.real.of_.binary_.modulo_._RemainderX._Remainder_1positive(
				r
				,
				nilnul.num.real_.TauX.IntoDouble
			);

			//return nilnul.num.real_.floored._TailX.Doub(
			//	r / nilnul.num.real_.TauX.IntoDouble
			//) * nilnul.num.real_.TauX.IntoDouble
			//;
		}

		/// <summary>
		/// [-pi,pi]
		/// </summary>
		/// <param name="r"></param>
		/// <returns></returns>
		static public double _OfAbsLePi(double r)
		{
			//if (r <= -Math.PI)
			//{
			//	return Math.PI;
			//}

			if (r < 0)
			{
				return r + nilnul.num.real_.TauX.IntoDouble; // [pi, 2pi)
			}

			return r;	/// [0,Pi]
		}

		static public DirectionDbl Create_byCannonize_assumeNeighborTau(double r)
		{
			if (r < 0)
			{
				return new DirectionDbl(r + nilnul.num.real_.TauX.IntoDouble);
			}
			return new DirectionDbl(r);

		}



		public static DirectionDbl Create_byCannonize(RotationOfDoubleI rotation)
		{
			return Create_byCannonize(rotation.quantity);
		}




	}
}
