using nilnul.obj._measure._unit_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._area
{

	/// <summary>
	/// square meterS
	/// </summary>
	public class Unit4dbl :
		nilnul.obj._measure.Unit4dbl
		,
		Unit4dblI

	{
		public Unit4dbl():base()
		{
		}

		static public Unit4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Unit4dbl>.Instance;
			}
		}

	}
}
