using nilnul.num;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._rotation.unit_
{
	/// <summary>
	/// one degree =  1/360 round.
	/// </summary>
	public class Deg4dbl : _rotation.Unit4dblA
	{

		public const double MAGNITUDE = Turn4dbl.MAGNITUDE/ 360;
		public Deg4dbl()
			:
			base(
				MAGNITUDE
			)
		{
		}


		static public Deg4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Deg4dbl>.Instance;
			}
		}

	}
}
