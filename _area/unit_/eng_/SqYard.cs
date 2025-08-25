using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using qr = nilnul.num.real_;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;

namespace nilnul.geometry.planar._area.unit_.eng_
{
	public class SqYard : UnitI
	{


		static public SqYard Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<SqYard>.Instance;
			}
		}

		//static public readonly SqYard Singleton = SingletonByDefault<SqYard>.Instance;

		public nilnul.num.Quotient1 _magAsQuotient
		{
			get
			{
				return qr.quotient.op_.unary_.Square.Eval(
					nilnul.geometry.linear_._measured.unit_.eng_.Yard.AsMeters
				);
			}
		}
		public nilnul.num.real_.PositiveI magnitude
		{
			get
			{
				return new qr.Positive(
					qr.quotient.op_.unary_.Square.Eval(
						nilnul.geometry.linear_._measured.unit_.eng_.Yard.AsMeters
					)
				);
			}
		}


	}

}
