using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar._area._unit;


using qr = nilnul.num.real_;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;

namespace nilnul.geometry.planar._area.unit
{
	[Obsolete()]
	public class SqYard: UnitI
	{


		static public SqYard Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<SqYard>.Instance;
			}
		}

		//static public readonly SqYard Singleton = SingletonByDefault<SqYard>.Instance;

		public Qr asSqMeters
		{
			get
			{
				return qr.quotient.op_.unary_.Square.Eval(nilnul.geometry._length.unit.foot.Yard.Singleton.AsMeters);
				throw new NotImplementedException();
			}
		}

		R AsSqMetersI.asSqMeters
		{
			get
			{
				return asSqMeters;
				throw new NotImplementedException();
			}
		}
	}
}
