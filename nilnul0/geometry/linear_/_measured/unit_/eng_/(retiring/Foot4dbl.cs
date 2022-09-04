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
	[Obsolete(nameof(Foot4dbl1))]

	public class Foot4dbl:
		Unit4dblA
		,
		Eng4dblI
	{
		public const double MsPerFoot=.3048;
		public const double Foot_Per_Meter=1/MsPerFoot;
		public Foot4dbl():base(MsPerFoot)
		{
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
		static public Foot4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Foot4dbl>.Instance;
			}
		}
	}
}
