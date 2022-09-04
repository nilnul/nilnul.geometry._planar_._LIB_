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
	/// alias:
	///		direction
	///			degree inside a turn.
	public class Direction : planar.rotation_.nonneg_.LtTau
	{
		public Direction(LtTau val) : base(val)
		{
		}

		public Direction(Real real) : this(new LtTau(real))
		{
		}

		public Direction(R realI) : this(new LtTau(realI))
		{
		}

		static public bool operator ==(Direction x, nilnul.num.RealI y){
			return nilnul.num.real.Eq.Singleton.Equals(x, y);
	}
		static public bool operator !=(Direction x, nilnul.num.RealI y){
			return !(x == y);
	}

		static public Direction Create_byCannonize(Real r) {
			return new Direction(
				nilnul.num.real_.floored._TailX.RealI(r / nilnul.num.real_.Tau.Singleton).ToReal() *nilnul.num.real_.Tau.Singleton
			);
		}
		static public Direction Create_byCannonize(R r) {
			return Create_byCannonize(r.ToReal());
		}

		static public DirectionDbl Create_byCannonize(double r) {
#if TRACE
			double v = nilnul.num.real_.floored._TailX.Doub(r / nilnul.num.real_.TauX.IntoDouble) * nilnul.num.real_.TauX.IntoDouble;
			var t = v;

#endif

			return new DirectionDbl(
				nilnul.num.real_.floored._TailX.Doub(r / nilnul.num.real_.TauX.IntoDouble) *nilnul.num.real_.TauX.IntoDouble
			);
		}


		static public Direction Create_byCannonize_assumeNeighborTau(Real r) {
			if (r<0)
			{
				return new Direction( r + nilnul.num.real_.Tau.Singleton);
			}
			return new Direction( r );
			
		}

		static public Direction Create_byCannonize_assumeNeighborTau(R r) {
			return Create_byCannonize_assumeNeighborTau(new Real(r));
		}

		public static Direction Create_byCannonize(RotationI1 rotation)
		{
			return Create_byCannonize(rotation.quantity);
		}

		public static Direction Create_byCannonize(Rotation1 rotation)
		{
			return Create_byCannonize(rotation.quantity);
		}




	}
	static public class DirectionX
	{
		static public Direction Direction(this RotationI1 rotation) {
			return rotation_.Direction.Create_byCannonize(rotation);
		}

	}
}
