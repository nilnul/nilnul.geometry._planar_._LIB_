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

	public class Are: UnitI
	{

		static public readonly Are Singleton = SingletonByDefault<Are>.Instance;

		public static readonly Q AsSqMeters = 100; 
		public Qr asSqMeters
		{
			get
			{
				return AsSqMeters;
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
