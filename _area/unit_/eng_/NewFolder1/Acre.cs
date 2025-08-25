using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using qr = nilnul.num.real_;
using Qr = nilnul.num.real_.Quotient;
using Q = nilnul.num.Quotient1;
using nilnul.geometry.planar._area._unit;
using R = nilnul.num.Real;
using RI = nilnul.num.RealI;

namespace nilnul.geometry.planar._area.unit
{
	[Obsolete()]

	public class Acre: UnitI
	{

		static public readonly Acre Singleton = SingletonByDefault<Acre>.Instance;

		public static readonly Q AsRoods = 4; 
		public Qr asSqMeters
		{
			get
			{
				return AsRoods *nilnul.geometry.planar._area.unit.Rood.Singleton.asSqMeters;
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
