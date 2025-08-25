using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.Real;

using qr = nilnul.num.real_;
using Qr = nilnul.num.real_.Quotient;
using Q = nilnul.num.Quotient1;
using nilnul.num;

namespace nilnul.geometry.planar._area.unit_.eng_
{
	public class Perch: UnitI
	{


		public static readonly Q AsSqYards = 30 + nilnul.num.Quotient1.CreateUnit(4);

		public nilnul.num.Quotient1 _magInQuotient {
			get {
				return AsSqYards * nilnul.geometry.planar._area.unit_.eng_.SqYard.Singleton._magAsQuotient;
			}
		}
		public nilnul.num.real_.PositiveI magnitude
		{
			get
			{
				return new qr.Positive( AsSqYards *nilnul.geometry.planar._area.unit_.eng_.SqYard.Singleton.magnitude.real.en.ToReal());
			}
		}

		

		static public Perch Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Perch>.Instance;
			}
		}

	}
}
