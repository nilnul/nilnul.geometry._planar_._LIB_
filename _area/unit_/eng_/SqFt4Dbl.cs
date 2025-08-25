using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using qr = nilnul.num.real_;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;
using nilnul.num;


namespace nilnul.geometry.planar.sub._area.unit_.eng_
{
	public class SqFt4Dbl
		:
		Unit4dblA
		,
		Eng4dblI
	{

		public SqFt4Dbl() : base(
			nilnul.num.real.op_.unary_.Square.Singleton.op(

nilnul.geometry.linear_._measured.unit_.eng_.Foot4dbl1.Singleton.magnitude.dblen.ee
			)
		)
		{
		}


		static public SqFt4Dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<SqFt4Dbl>.Instance;
			}
		}

	}
}
