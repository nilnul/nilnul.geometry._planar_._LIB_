using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry._length.unit
{
	[Obsolete(nameof(nilnul.geometry._linear._length.Unit))]
	public class Meter : UnitI
	{

		static public readonly Meter Singleton = SingletonByDefault<Meter>.Instance;

		public double AsMeters
		{
			get
			{
				return 1;
				throw new NotImplementedException();
			}
		}
		public override string ToString()
		{
			return "m";
		}
	}
}
