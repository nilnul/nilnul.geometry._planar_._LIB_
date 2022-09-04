using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;
using Rx = nilnul.num.RealIX;
using RI = nilnul.num.RealI;
using nilnul.num;
using nilnul.geometry.planar._rotation;
using nilnul.obj._measure_;

namespace nilnul.geometry.planar
{
	
	
	[Obsolete(nameof(planar.rotation_.Radian4dbl))]
	public class RotationOfDouble:
		//Real   //we here prefer aggregation over inheritance per the suggestion of DesignPatterns
		
		Rotation4dbl<_rotation.UnitOfDouble>
		,

		RotationOfDoubleI
	{
		public const double TAU = nilnul.num.real_.TauX.IntoDouble;
		public static  double HalfTau=nilnul.num.real_.TauX.HalfD;
		public static double QuarterTau=nilnul.num.real_.TauX.QuarterD;


		Unit4dblI Unit4dblI<Unit4dblI>.unit => base.unit;

		//UnitOfDoubleI UnitI1<UnitOfDoubleI>.unit => base.unit;

		//private double _radian;

		//public double quantity
		//{
		//	get { return _radian; }
		//	set { _radian = value; }
		//}

		//public _rotation.UnitOfDoubleI unit => _rotation.UnitOfDouble.Singleton;

		public RotationOfDouble(double radian):base(
			radian, _rotation.UnitOfDouble.Singleton
		)
		{
			//_radian = radian;
		}



		static public implicit operator RotationOfDouble(double real) {
			return new RotationOfDouble(real);
		}
		static public implicit operator double(RotationOfDouble real) {
			return (real).quantity;
		}


		static public RotationOfDouble CreateZero() {
			return new RotationOfDouble(
				0	
			);
		}

		static public bool operator ==(RotationOfDouble a, RotationOfDouble i) {
			return a.quantity == i.quantity;
		}

		static public bool operator !=(RotationOfDouble a, RotationOfDouble i) {
			return !(a == i);
		}

		static public bool operator ==(RotationOfDouble a, int i) {
			return a == new RotationOfDouble(i);
		}


		static public bool operator !=(RotationOfDouble a, int i) {
			return !(a == (i) );
		}

		static public bool operator ==( int i, RotationOfDouble a) {
			return a == (i);
		}


		static public bool operator !=( int i, RotationOfDouble a) {
			return a != (i) ;
		}


	}
}
