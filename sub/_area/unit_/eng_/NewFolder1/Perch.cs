using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.Real;

using qr = nilnul.num.real_;
using Qr = nilnul.num.real_.Quotient;
using Q = nilnul.num.Quotient1;
using nilnul.geometry.planar._area._unit;

namespace nilnul.geometry.planar._area.unit
{
	[Obsolete()]

	public class Perch: UnitI
	{

		static public readonly Perch Singleton = SingletonByDefault<Perch>.Instance;

		public static readonly Q AsSqYards = 30 + nilnul.num.Quotient1.CreateUnit(4); 
		public Qr asSqMeters
		{
			get
			{
				return AsSqYards *nilnul.geometry.planar._area.unit.SqYard.Singleton.asSqMeters;
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
