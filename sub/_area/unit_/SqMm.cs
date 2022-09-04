using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._area.unit_
{
	public class SqMm4Dbl
		:
		_area.Unit4dblA
	{
		public SqMm4Dbl() : base(
			1d/(1000 * 1000)
		)
		{
		}

		static public SqMm4Dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<SqMm4Dbl>.Instance;
			}
		}

	}
}
