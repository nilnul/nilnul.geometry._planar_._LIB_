using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using qr = nilnul.num.real_;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;

namespace nilnul.geometry.planar.sub._area.unit_.eng_
{
	public class SqYard4Dbl : Unit4dblA
	{
	

		public SqYard4Dbl() : base(
			nilnul.num.real.op_.unary_.Square.Singleton.op(

nilnul.geometry.linear_._measured.unit_.eng_.Yard4dbl.Singleton.magnitude.dblen.ee
			)
		)
		{
		}


		static public SqYard4Dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<SqYard4Dbl>.Instance;
			}
		}

	}
}
