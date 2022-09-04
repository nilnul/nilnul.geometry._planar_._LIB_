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
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete()]

	public class Hectare: UnitI
	{

		static public readonly Hectare Singleton = SingletonByDefault<Hectare>.Instance;

		public static readonly Q AS_AREs = 100; 
		public Qr asSqMeters
		{
			get
			{
				return AS_AREs*Are.AsSqMeters;
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
