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

namespace nilnul.geometry.planar.rotation_
{
	
	

	public class Radian4dbl:
		//Real   //we here prefer aggregation over inheritance per the suggestion of DesignPatterns
		
		Rotation4dbl
		,

		RotationOfDoubleI
	{
		

		public Radian4dbl(double radian):base(
			radian, _rotation.UnitOfDouble.Singleton
		)
		{
			//_radian = radian;
		}



		static public implicit operator Radian4dbl(double real) {
			return new Radian4dbl(real);
		}
		static public implicit operator double(Radian4dbl real) {
			return (real).quantity;
		}


		static public Radian4dbl CreateZero() {
			return new Radian4dbl(
				0	
			);
		}

		static public bool operator ==(Radian4dbl a, Radian4dbl i) {
			return a.quantity == i.quantity;
		}

		static public bool operator !=(Radian4dbl a, Radian4dbl i) {
			return !(a == i);
		}

		static public bool operator ==(Radian4dbl a, int i) {
			return a == new Radian4dbl(i);
		}


		static public bool operator !=(Radian4dbl a, int i) {
			return !(a == (i) );
		}

		static public bool operator ==( int i, Radian4dbl a) {
			return a == (i);
		}


		static public bool operator !=( int i, Radian4dbl a) {
			return a != (i) ;
		}


	}
}
