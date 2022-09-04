using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R1 = nilnul.num.RealI;
using r = nilnul.num.real;
using q = nilnul.num.quotient;


using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;

using nilnul.num.real_;

namespace nilnul.geometry.linear_._measured.unit_.eng_
{
	public class Foot:
		UnitA
		
		,
		UnitI
		,EngI

	{

	

		public const double MsPerFoot=.3048;

		public const double Foot_Per_Meter=1/MsPerFoot;

		public Foot():base(new nilnul.num.real_.Positive(AsMeters) )
		{
		}

		static public num.real_.Quotient AsMeters
		{
			get
			{
				return new num.real_.Quotient(
						new nilnul.num.quotient_.radix_.Dec1(3048,-4)	//.toQ()
				);
			}
		}

		public PositiveI asMeters
		{
			get
			{
				return this.magnitude ;
			}
		}


		public override string ToString()
		{
			return "ft";
		}

		public static double FeetFroMeters(double meters) {

			return meters * Foot_Per_Meter;
		
		}

		public static double MetersFroFeet(double feet)
		{

			return feet * MsPerFoot;

		}


		static public Foot Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Foot>.Instance;
			}
		}


	}
}
