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


namespace nilnul.geometry.planar._area.unit_.eng_
{
	public class SquareFt
		:EngI
	{
		public static double SquareM_per_SqFt = nilnul.num.real.doubl.op.Square.Eval( nilnul.geometry.linear_._measured.unit_.eng_.Foot.MsPerFoot);


		public static R ToSqMeters(int v)
		{
			return ToSqMeters(
				new nilnul.num.real_.Quotient(v)
				);
			//throw new NotImplementedException();
		}

		public Qr asSqMeters
		{
			get
			{
				return num.real_.quotient.op_.unary_.Square.Eval(nilnul.geometry.linear_._measured.unit_.eng_.Foot.AsMeters);
				throw new NotImplementedException();
			}
		}

	
		public qr.PositiveI magnitude => new qr.Positive(asSqMeters);

		static public R ToSqMeters(R sqFeet/*= new nilnul.num.real_.Quotient(1)*/)
		{


			//return sqFeet.Multi(Singleton.asSqMeters);
			return nilnul.num.Real.Ov(nilnul.num.RealIX.Multi(sqFeet, Singleton.asSqMeters));


		}

		static public SquareFt Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<SquareFt>.Instance;
			}
		}

	}
}
