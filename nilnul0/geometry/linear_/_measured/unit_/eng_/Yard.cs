using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using nilnul.num.real_;
using Quotient = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;

namespace nilnul.geometry.linear_._measured.unit_.eng_
{
	public class Yard : EngI
	{


		public const double MetersPerYard = Foot.MsPerFoot * 3;   // 0.9144;
		public const int AsFeet = 3;



		static public Quotient AsMeters
		{
			get
			{
				return AsFeet * Foot.AsMeters;
				//throw new NotImplementedException();
			}
		}


		public PositiveI magnitude =>  new nilnul.num.real_.Positive(AsMeters);


		static public Yard Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Yard>.Instance;
			}
		}

	}
}
