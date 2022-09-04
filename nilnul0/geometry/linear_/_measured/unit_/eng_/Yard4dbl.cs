using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using nilnul.num.real_;
using Quotient = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;

namespace nilnul.geometry.linear_._measured.unit_.eng_
{
	public class Yard4dbl
		:
		EngAsInches4DblA
		,
		Eng4dblI
	{

		public const int FEET_PER_THIS = 3;

		public Yard4dbl() : base(
			FEET_PER_THIS*Foot4dbl1.Singleton.inches
			)
		{
		}

	



		static public Yard4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Yard4dbl>.Instance;
			}
		}

	}
}
