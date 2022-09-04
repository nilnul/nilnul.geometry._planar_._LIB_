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
	public class Foot4dbl1:
		EngAsInches4DblA
		,
		Eng4dblI
	{
		
		public const int INCHES_PER_THIS = 12;
		public Foot4dbl1():base(INCHES_PER_THIS)
		{
		}

		public override string ToString()
		{
			return "ft";
		}

		static public Foot4dbl1 Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Foot4dbl1>.Instance;
			}
		}
	}
}
