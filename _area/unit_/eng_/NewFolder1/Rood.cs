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

namespace nilnul.geometry.planar._area.unit
{
	[Obsolete()]

	public class Rood: UnitI
	{

		static public readonly Rood Singleton = SingletonByDefault<Rood>.Instance;

		public static readonly Q AsPerchs = 40; 
		public Qr asSqMeters
		{
			get
			{
				return AsPerchs *nilnul.geometry.planar._area.unit.Perch.Singleton.asSqMeters;
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
